using System.Windows.Forms;

namespace NalivARM10
{
    public class WayTreeNode : TreeNode
    {
        public WayTreeNode(string text) : base(text) { }

        public string WayId { get; set; }
    }
}
