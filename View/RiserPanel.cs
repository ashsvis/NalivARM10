using NalivARM10.Model;
using System;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserPanel : UserControl
    {
        private readonly RiserKey key;

        public RiserPanel(RiserKey key)
        {
            InitializeComponent();
            riserControl1.Key = key;
            riserControl1.Riser = key.Number;
            this.key = key;
        }

        public uint Number { get => riserControl1.Riser; }

        public event FocusRiser IsFocused;

        private void RiserPanel_Load(object sender, EventArgs e)
        {
            if (Data.Risers.TryGetValue(key, out Riser riser))
            {
                var buff = new ushort[60];
                buff[0] = (ushort)riser.Level;
                riserControl1.UpdateData(buff, false);
            }
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
