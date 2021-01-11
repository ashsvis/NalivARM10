using NalivARM10.Model;
using System;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserPanel : UserControl
    {
        public RiserKey RiserKey { get; private set; }

        public RiserPanel(RiserKey key)
        {
            InitializeComponent();
            riserControl1.Key = key;
            riserControl1.Riser = key.Number;
            this.RiserKey = key;
        }

        public uint Number { get => riserControl1.Riser; }

        public event FocusRiser IsFocused;

        private void RiserPanel_Load(object sender, EventArgs e)
        {
        }

        public void UpdateData(ushort[] hregs)
        {
            riserControl1.UpdateData(hregs);
            chboxSelected.Enabled = btnStart.Enabled = btnStop.Enabled = riserControl1.Linked;
        }

        /// <summary>
        /// Получение фокуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RiserPanel_Enter(object sender, EventArgs e)
        {
            riserControl1.Selected = true;
            riserControl1.Invalidate();
            IsFocused?.Invoke(this);
        }

        /// <summary>
        /// Потеря фокуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
