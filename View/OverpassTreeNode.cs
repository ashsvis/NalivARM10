using System.Windows.Forms;

namespace NalivARM10
{
    public class OverpassTreeNode : TreeNode
    {
        public OverpassTreeNode(string text) : base(text) { }

        public string OverpassId { get; set; }
    }
}
