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

        public int Riser 
        { 
            get => riserControl1.Riser; 
            set => riserControl1.Riser = value; 
        }

        public event FocusRiser IsFocused;

        private void RiserPanel_Load(object sender, EventArgs e)
        {
            riserControl1.UpdateData(new ushort[60], false);
        }

        private void RiserPanel_Enter(object sender, EventArgs e)
        {
            riserControl1.Selected = true;
            riserControl1.Invalidate();
            IsFocused?.Invoke(this);
        }

        private void RiserPanel_Leave(object sender, EventArgs e)
        {
            riserControl1.Selected = false;
            riserControl1.Invalidate();
        }

        public override string ToString()
        {
            return $"Стояк №{riserControl1.Riser}";
        }
    }

    public delegate void FocusRiser(RiserPanel panel);
}
