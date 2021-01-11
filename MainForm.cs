using NalivARM10.Model;
using NalivARM10.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NalivARM10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfig();

        }

        /// <summary>
        /// Загрузка конфигурационных данных
        /// </summary>
        private void LoadConfig()
        {
            var configName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NalivARM.xml");
            if (!File.Exists(configName)) return;
            // чтение конфигурационного файла
            var xdoc = XDocument.Load(configName);
            tvRails.Nodes.Clear();
            var root = new TreeNode("ПТХН");
            tvRails.Nodes.Add(root);
            var fetchers = new Dictionary<BackgroundWorker, Tuning>();

            foreach (XElement overpass in xdoc.Element("Configuration").Elements("Overpass"))
            {
                var overpassId = overpass.Attribute("Id")?.Value;
                var name = overpass.Attribute("Name")?.Value;
                if (name == null) continue;
                var overpassNode = new OverpassTreeNode(name) { OverpassId = overpassId };
                root.Nodes.Add(overpassNode);
                foreach (XElement way in overpass.Elements("Way"))
                {
                    var wayId = way.Attribute("Id")?.Value;
                    name = way.Attribute("Name")?.Value;
                    if (name == null) continue;
                    var wayNode = new WayTreeNode(name) { WayId = wayId };
                    overpassNode.Nodes.Add(wayNode);
                    foreach (XElement product in way.Elements("Product"))
                    {
                        var productId = product.Attribute("Id")?.Value;
                        name = product.Attribute("Name")?.Value;
                        if (name == null) continue;
                        var productNode = new ProductTreeNode(name) { ProductId = productId };
                        wayNode.Nodes.Add(productNode);
                        foreach (XElement segment in product.Elements("Segment"))
                        {
                            var linkType = segment.Attribute("Type")?.Value;
                            if (linkType == null) continue;
                            var serial = segment.Attribute("Serial")?.Value;
                            var ethernet = segment.Attribute("Ethernet")?.Value;
                            var segmentId = Guid.NewGuid();
                            Data.Segments.TryAdd(segmentId, new SerialChannel(serial));
                            
                            productNode.Segments.Add(segment, segmentId);

                            var riserKeys = new List<RiserKey>();
                            foreach (XElement riserElement in segment.Elements("Riser").OrderBy(item => int.Parse(item.Attribute("Number")?.Value)))
                            {
                                var number = riserElement.Attribute("Number")?.Value;
                                if (number == null || !uint.TryParse(number, out uint riserNumber)) continue;
                                var nodeAddr = riserElement.Attribute("NodeAddr")?.Value;
                                if (nodeAddr == null || !byte.TryParse(nodeAddr, out byte addr)) continue;
                                var nodeFunc = riserElement.Attribute("NodeFunc")?.Value;
                                if (nodeFunc == null || !byte.TryParse(nodeFunc, out byte func)) continue;
                                var key = new RiserKey(overpassId, wayId, productId, riserNumber, segmentId, addr, func);
                                var riser = new Riser() { Key = key };
                                riserKeys.Add(key);
                                // загрузка объектов стояков
                                Data.Risers.TryAdd(key, riser);
                            }
                            //
                            var fetcher = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
                            fetcher.ProgressChanged += Fetcher_ProgressChanged;
                            switch (linkType)
                            {
                                case "Ethernet":
                                    fetcher.DoWork += EthernetFetcher_DoWork;
                                    fetchers.Add(fetcher, new EthernetTuning(ethernet) { SegmentId = segmentId, RiserKeys = riserKeys });
                                    break;
                                case "Serial":
                                    fetcher.DoWork += SerialFetcher_DoWork;
                                    fetchers.Add(fetcher, new SerialTuning(serial) { SegmentId = segmentId, RiserKeys = riserKeys });
                                    break;
                            }

                        }
                    }
                }
            }
            // запуск потоков опроса
            foreach (var item in fetchers)
            {
                item.Key.RunWorkerAsync(item.Value);
            }
        }

        /// <summary>
        /// Обработчик для потока данных по COM-порту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialFetcher_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            if (!(e.Argument is SerialTuning pars)) return;
            if (!Data.Segments.TryGetValue(pars.SegmentId, out Channel channel)) return;
            channel.Open();
            if (channel.IsOpen)
            {
                try
                {
                    var queue = new Queue<RiserKey>(pars.RiserKeys);
                    var lastsecond = DateTime.Now.Second;
                    while (!worker.CancellationPending)
                    {
                        Thread.Sleep(1);
                        var dt = DateTime.Now;
                        if (lastsecond == dt.Second) continue;
                        lastsecond = dt.Second;
                        // прошла секунда
                        try
                        {
                            var list = new List<RiserKey>();
                            while (queue.Count > 0)
                            {
                                var key = queue.Dequeue();
                                list.Add(key);
                                var address = 0;
                                var datacount = 9; // max 61;

                                var fetchvals = Channel.Fetch(channel, key, address, datacount);

                                if (Data.Risers.TryGetValue(key, out Riser riser))
                                    riser.Update(fetchvals);
                            }
                            foreach (var key in list)
                                queue.Enqueue(key);
                        }
                        catch (Exception ex)
                        {
                            worker.ReportProgress(0, ex.Message);
                        }
                    }
                }
                finally
                {
                    channel.Close();
                }
            }
        }

        /// <summary>
        /// Обработчик для потока данных по TCP соединению
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EthernetFetcher_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            if (!(e.Argument is EthernetTuning pars)) return;
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                socket.SendTimeout = 5000;
                socket.ReceiveTimeout = 5000;
                try
                {
                    var remoteEp = new IPEndPoint(pars.Address, pars.Port);
                    socket.Connect(remoteEp);
                    Thread.Sleep(500);
                    if (socket.Connected)
                    {
                        worker.ReportProgress(0, $"Сокет {remoteEp} подключен");
                        var lastsecond = DateTime.Now.Second;
                        while (!worker.CancellationPending)
                        {
                            var dt = DateTime.Now;
                            if (lastsecond == dt.Second) continue;
                            lastsecond = dt.Second;
                            // прошла секунда
                            try
                            {

                            }
                            catch (Exception ex)
                            {
                                worker.ReportProgress(0, ex.Message);
                            }
                        }
                    }
                    else
                        worker.ReportProgress(0, $"Сокет {remoteEp} не подключен");
                }
                catch (Exception ex)
                {
                    worker.ReportProgress(0, ex.Message);
                }
            }
        }

        private void Fetcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
                Console.WriteLine($"{e.UserState}");
        }

        /// <summary>
        /// Выбор узла в дереве
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvRails_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!(e.Node is ProductTreeNode productNode)) return;
            var list = new List<RiserPanel>();
            foreach (var segment in productNode.Segments)
            {
                var productId = productNode.ProductId;
                var wayId = ((WayTreeNode)productNode.Parent).WayId;
                var overpassId = ((OverpassTreeNode)productNode.Parent.Parent).OverpassId;
                foreach (var riserElement in segment.Key.Elements("Riser").OrderBy(item => int.Parse(item.Attribute("Number")?.Value)))
                {
                    var number = riserElement.Attribute("Number")?.Value;
                    if (number == null || !uint.TryParse(number, out uint riserNumber)) continue;
                    var nodeAddr = riserElement.Attribute("NodeAddr")?.Value;
                    if (nodeAddr == null || !uint.TryParse(nodeAddr, out uint addr)) continue;
                    var nodeFunc = riserElement.Attribute("NodeFunc")?.Value;
                    if (nodeFunc == null || !byte.TryParse(nodeFunc, out byte func)) continue;
                    var pan = new RiserPanel(new RiserKey(overpassId, wayId, productId, riserNumber, segment.Value, addr, func));
                    if (Data.Risers.TryGetValue(pan.RiserKey, out Riser riser))
                        pan.UpdateData(riser.Registers);
                    pan.IsFocused += Pan_IsFocused;
                    list.Add(pan);
                }
            }
            tscbRisersList.Items.Clear();
            panRisers.SuspendLayout();
            panRisers.Controls.Clear();
            foreach (var pan in list.OrderBy(item => item.Number))
            {
                panRisers.Controls.Add(pan);
                tscbRisersList.Items.Add(pan);
            }
            panRisers.ResumeLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var pan in panRisers.Controls.OfType<RiserPanel>())
            {
                if (Data.Risers.TryGetValue(pan.RiserKey, out Riser riser))
                    pan.UpdateData(riser.Registers);
            }
        }

        /// <summary>
        /// Панель со стояком была выбрана указателем,
        /// поэтому выбираем номер стояка из выпадающего списка обратным ходом
        /// </summary>
        /// <param name="panel"></param>
        private void Pan_IsFocused(RiserPanel panel)
        {
            tscbRisersList.SelectedIndexChanged -= tscbRisersList_SelectedIndexChanged;
            tscbRisersList.SelectedItem = panel;
            tscbRisersList.SelectedIndexChanged += tscbRisersList_SelectedIndexChanged;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tscbRisersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pan = (RiserPanel)tscbRisersList.SelectedItem;
            pan?.Focus();
        }

        private void tscbRisersList_DropDownClosed(object sender, EventArgs e)
        {
            var pan = (RiserPanel)tscbRisersList.SelectedItem;
            pan?.Focus();
        }

        /// <summary>
        /// Вызов статуса стояка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiStatus_Click(object sender, EventArgs e)
        {
            var pan = (RiserPanel)tscbRisersList.SelectedItem;
            if (pan == null) return;
            // среди открытых форм ищем окно статуса стояка, если его нет, создаём новое
            var statusForm = Application.OpenForms.OfType<StatusForm>().FirstOrDefault() ?? new StatusForm(pan.RiserKey) { Owner = this };
            statusForm.RiserKey = pan.RiserKey;
            statusForm.Show();
            statusForm.BringToFront();
        }

        /// <summary>
        /// Вызов формы настройки свойств стояка
        /// </summary>
        /// <param name="tabNo">Номер вкладки окна настройки</param>
        private void ShowRiserConfig(int tabNo)
        {
            var pan = (RiserPanel)tscbRisersList.SelectedItem;
            if (pan == null) return;
            // среди открытых форм ищем окно настройки стояка, если его нет, создаём новое
            var configForm = Application.OpenForms.OfType<RiserTuningForm>().FirstOrDefault() ?? new RiserTuningForm(pan.RiserKey, tabNo) { Owner = this };
            configForm.RiserKey = pan.RiserKey;
            configForm.TabNo = tabNo;
            configForm.Show();
            configForm.BringToFront();
        }

        /// <summary>
        /// Меню: Конфигурация стояка/Связь...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLink_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(0);
        }

        /// <summary>
        /// Меню: Конфигурация стояка/PLC...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPLC_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(1);
        }

        /// <summary>
        /// Меню: Конфигурация стояка/ADC...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiADC_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(2);
        }

        /// <summary>
        /// Меню: Конфигурация стояка/Сигнализатор аварийный...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAlarmLevel_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(3);
        }

        /// <summary>
        /// Меню: Конфигурация стояка/Сигнализатор уровня...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiProductLevel_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(4);
        }
    }
}
