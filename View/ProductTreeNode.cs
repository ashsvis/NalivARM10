using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NalivARM10
{
    public class ProductTreeNode : TreeNode
    {
        public ProductTreeNode(string text) : base(text)  {}

        public string ProductId { get; set; }

        public List<XElement> Segments = new List<XElement>();

    }
}
