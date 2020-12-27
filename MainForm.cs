using NalivARM10.Model;
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
                            productNode.Segments.Add(segment);
                            //
                            var fetcher = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
                            fetcher.ProgressChanged += Fetcher_ProgressChanged;
                            switch (linkType)
                            {
                                case "Ethernet":
                                    fetcher.DoWork += EthernetFetcher_DoWork;
                                    fetchers.Add(fetcher, new EthernetTuning(ethernet));
                                    break;
                                case "Serial":
                                    fetcher.DoWork += SerialFetcher_DoWork;
                                    fetchers.Add(fetcher, new SerialTuning(serial));
                                    break;
                            }
                            foreach (XElement riserElement in segment.Elements("Riser").OrderBy(item => int.Parse(item.Attribute("Number")?.Value)))
                            {
                                var number = riserElement.Attribute("Number")?.Value;
                                if (number == null || !uint.TryParse(number, out uint riserNumber)) continue;
                                var nodeAddr = riserElement.Attribute("NodeAddr")?.Value;
                                if (nodeAddr == null || !byte.TryParse(nodeAddr, out byte addr)) continue;
                                var riser = new Riser() { OverpassId = overpassId, WayId = wayId, ProductId = productId, Number = riserNumber, NodeAddr = addr };
                                Data.Risers.TryAdd(new RiserKey(overpassId, wayId, productId, riserNumber), riser);
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
            using (var port = new ModbusSerialPort())
            {
                port.PortName = pars.PortName;
                port.BaudRate = pars.BaudRate;
                port.Parity = pars.Parity;
                port.StopBits = System.IO.Ports.StopBits.Two;
                try
                {
                    port.Open();
                    worker.ReportProgress(0, $"{port.PortName} открыт");
                    try
                    {
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

                            }
                            catch (Exception ex)
                            {
                                worker.ReportProgress(0, ex.Message);
                            }
                        }

                    }
                    finally
                    {
                        port.Close();
                    }
                }
                catch (Exception ex)
                {
                    worker.ReportProgress(0, ex.Message);
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
                foreach (XElement riser in segment.Elements("Riser").OrderBy(item => int.Parse(item.Attribute("Number")?.Value)))
                {
                    var number = riser.Attribute("Number")?.Value;
                    if (number == null || !uint.TryParse(number, out uint riserNumber)) continue;
                    var nodeAddr = riser.Attribute("NodeAddr")?.Value;
                    if (nodeAddr == null) continue;
                    var pan = new RiserPanel(new RiserKey(overpassId, wayId, productId, riserNumber));
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
    }
}
