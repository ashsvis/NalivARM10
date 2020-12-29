using NalivARM10.Model;
using NalivARM10.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Ports;
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
                        var datacount = 61;

                        var sendBytes = EncodeData((byte)key.NodeAddr, key.Func,
                                                   (byte)(address >> 8), (byte)(address & 0xff),
                                                   (byte)(datacount >> 8), (byte)(datacount & 0xff), 0, 0);
                        var buff = new List<byte>(sendBytes);
                        var crc = BitConverter.GetBytes(Crc(buff.ToArray(), buff.Count - 2));
                        sendBytes[sendBytes.Length - 2] = crc[0];
                        sendBytes[sendBytes.Length - 1] = crc[1];

                        var len = (sendBytes[4] * 256 + sendBytes[5]) * 2 + 5;

                        if (!Data.Segments.TryGetValue(key.SegmentId, out Channel channel)) continue;
                        channel.Open();
                        if (channel.IsOpen)
                        {
                            try
                            {
                                channel.Write(sendBytes, 0, sendBytes.Length);
                                Thread.Sleep(200);
                                var bytesToRead = channel.BytesToRead;
                                if (bytesToRead == len)
                                {
                                    buff.Clear();
                                    while (len-- > 0)
                                        buff.Add((byte)channel.ReadByte());
                                    // конец приёма блока данных
                                    var crcCalc = Crc(buff.ToArray(), buff.Count - 2);
                                    var crcBuff = BitConverter.ToUInt16(buff.ToArray(), buff.Count - 2);
                                    if (crcCalc == crcBuff)
                                    {
                                        // данные получены правильно
                                        var regcount = buff[2] / 2;
                                        var fetchvals = new ushort[regcount];
                                        var n = 3;
                                        for (var i = 0; i < regcount; i++)
                                        {
                                            var raw = new byte[2];
                                            raw[0] = buff[n + 1];
                                            raw[1] = buff[n];
                                            fetchvals[i] = BitConverter.ToUInt16(raw, 0);
                                            n += 2;
                                        }
                                        //--------------------
                                        if (Data.Risers.TryGetValue(key, out Riser riser))
                                            riser.Update(fetchvals);
                                    }
                                    else
                                    {
                                        // ошибка контрольной суммы
                                        if (Data.Risers.TryGetValue(key, out Riser riser))
                                            riser.Update(new ushort[] { });
                                    }
                                }
                                else
                                {
                                    if (Data.Risers.TryGetValue(key, out Riser riser))
                                        riser.Update(new ushort[] { });
                                }
                            }
                            finally
                            {
                                channel.Close();
                            }
                        }
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

        private static byte[] EncodeData(params byte[] list)
        {
            var result = new byte[list.Length];
            for (var i = 0; i < list.Length; i++) result[i] = list[i];
            return result;
        }

        private static ushort Crc(IList<byte> buff, int len)
        {   // контрольная сумма MODBUS RTU
            ushort result = 0xFFFF;
            if (len <= buff.Count)
            {
                for (var i = 0; i < len; i++)
                {
                    result ^= buff[i];
                    for (var j = 0; j < 8; j++)
                    {
                        var flag = (result & 0x0001) > 0;
                        result >>= 1;
                        if (flag) result ^= 0xA001;
                    }
                }
            }
            return result;
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
            var statusForm = Application.OpenForms.OfType<StatusForm>().FirstOrDefault() ?? new StatusForm(pan.RiserKey) { Owner = this };
            statusForm.RiserKey = pan.RiserKey;
            statusForm.Show();
            statusForm.BringToFront();
        }

        private void ShowRiserConfig(int tabNo)
        {
            var pan = (RiserPanel)tscbRisersList.SelectedItem;
            if (pan == null) return;
            var configForm = Application.OpenForms.OfType<RiserTuningForm>().FirstOrDefault() ?? new RiserTuningForm(pan.RiserKey, tabNo) { Owner = this };
            configForm.RiserKey = pan.RiserKey;
            configForm.TabNo = tabNo;
            configForm.Show();
            configForm.BringToFront();
        }

        private void tsmiLink_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(0);
        }

        private void tsmiPLC_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(1);
        }

        private void tsmiADC_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(2);
        }

        private void tsmiAlarmLevel_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(3);
        }

        private void tsmiProductLevel_Click(object sender, EventArgs e)
        {
            ShowRiserConfig(4);
        }
    }
}
