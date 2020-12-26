using System;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserPanel : UserControl
    {
        public RiserPanel()
        {
            InitializeComponent();
        }

        private void RiserPanel_Load(object sender, EventArgs e)
        {
            riserControl1.UpdateData(new ushort[60], false);
        }
    }
}
