using System;
using System.Drawing;
using System.Windows.Forms;
using NalivARM10.Model;

namespace NalivARM10.View
{
    public partial class RiserTuningForm : Form
    {
        private int tabNo;

        public RiserTuningForm(RiserKey riserKey, int tabNo)
        {
            InitializeComponent();
            this.RiserKey = riserKey;
            this.tabNo = tabNo;
            tabControl1.SelectTab(tabNo);
        }

        public RiserKey RiserKey { get; set; }
        public int TabNo
        {
            get { return tabNo; }
            set
            {
                tabNo = value;
                tabControl1.SelectTab(tabNo);
            }
        }

        private void RiserTuningForm_Load(object sender, EventArgs e)
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
                riserTuningLink.UpdateData(riser.Registers);
                riserTuningPlc.UpdateData(riser.Registers);
                riserTuningAdc.UpdateData(riser.Registers);
                riserTuningAlarmLevel.UpdateData(riser.Registers);
                riserTuningAnalogLevel.UpdateData(riser.Registers);
            }
        }
    }
}
