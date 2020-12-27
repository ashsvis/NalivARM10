using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NalivARM10
{
    public class ProductTreeNode : TreeNode
    {
        public List<XElement> Segments = new List<XElement>();

        public ProductTreeNode(string text) : base(text)  {}
    }
}
