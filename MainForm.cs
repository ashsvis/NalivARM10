using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
            foreach (XElement overpass in xdoc.Element("Configuration").Elements("Overpass"))
            {
                var id = overpass.Attribute("Id")?.Value;
                var name = overpass.Attribute("Name")?.Value;
                if (name == null) continue;
                var overpassNode = new TreeNode(name) { Tag = id };
                root.Nodes.Add(overpassNode);
                foreach (XElement way in overpass.Elements("Way"))
                {
                    id = way.Attribute("Id")?.Value;
                    name = way.Attribute("Name")?.Value;
                    if (name == null) continue;
                    var wayNode = new TreeNode(name) { Tag = id };
                    overpassNode.Nodes.Add(wayNode);
                    foreach (XElement product in way.Elements("Product"))
                    {
                        id = product.Attribute("Id")?.Value;
                        name = product.Attribute("Name")?.Value;
                        if (name == null) continue;
                        var productNode = new ProductTreeNode(name) { Tag = id };
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
                                    fetcher.RunWorkerAsync(new EthernetTuning(ethernet));
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void EthernetFetcher_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            if (!(e.Argument is EthernetTuning pars)) return;
            var lastsecond = DateTime.Now.Second;
            var remoteEp = new IPEndPoint(pars.Address, pars.Port);
            while (!worker.CancellationPending)
            {
                var dt = DateTime.Now;
                if (lastsecond == dt.Second) continue;
                lastsecond = dt.Second;
                // прошла секунда


            }
        }

        private void Fetcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Выбор узла в дереве
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvRails_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!(e.Node is ProductTreeNode productNode)) return;
            tscbRisersList.Items.Clear();
            panRisers.SuspendLayout();
            panRisers.Controls.Clear();
            foreach (var segment in productNode.Segments)
            {
                foreach (XElement riser in segment.Elements("Riser"))
                {
                    var number = riser.Attribute("Number")?.Value;
                    if (number == null || !int.TryParse(number, out int riserNumber)) continue;
                    var nodeAddr = riser.Attribute("NodeAddr")?.Value;
                    if (nodeAddr == null) continue;
                    var pan = new RiserPanel() { Riser = riserNumber };
                    pan.IsFocused += Pan_IsFocused;
                    panRisers.Controls.Add(pan);
                    tscbRisersList.Items.Add(pan);
                }
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
