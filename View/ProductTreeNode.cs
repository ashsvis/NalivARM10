using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NalivARM10
{
    public class ProductTreeNode : TreeNode
    {
        public ProductTreeNode(string text) : base(text)  {}

        public string ProductId { get; set; }

        public Dictionary<XElement, Guid> Segments = new Dictionary<XElement, Guid>();

    }
}
