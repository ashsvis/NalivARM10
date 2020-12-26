using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
                        }
                    }
                }
            }
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
                foreach (XElement riser in segment.Elements("Riser"))
                {
                    var number = riser.Attribute("Number")?.Value;
                    if (number == null) continue;
                    var nodeAddr = riser.Attribute("NodeAddr")?.Value;
                    if (nodeAddr == null) continue;
                    list.Add(new RiserPanel());
                }
            }
            panRisers.SuspendLayout();
            panRisers.Controls.Clear();
            panRisers.Controls.AddRange(list.ToArray());
            panRisers.ResumeLayout();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiUsersList_Click(object sender, EventArgs e)
        {
        }
    }

    public class ProductTreeNode : TreeNode
    {
        public List<XElement> Segments = new List<XElement>();

        public ProductTreeNode(string text) : base(text)  {}
    }
}
