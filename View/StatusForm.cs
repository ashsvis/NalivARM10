using NalivARM10.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class StatusForm : Form
    {
        public StatusForm(RiserKey riserKey)
        {
            InitializeComponent();
            RiserKey = riserKey;
        }

        public RiserKey RiserKey { get; set; }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            if (Location == Point.Empty)
                CenterToScreen();
            timer1_Tick(timer1, new EventArgs());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Data.Risers.TryGetValue(RiserKey, out Riser riser))
            {
                Text = $"Стояк №{riser.Key.Number}";
                riserStatus.UpdateData(riser.Registers);
            }
        }
    }
}
