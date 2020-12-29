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

            riserTuningLink.OnWrite += RiserTuningLink_OnWrite;
            riserTuningPlc.OnWrite += RiserTuningLink_OnWrite;
            riserTuningAdc.OnWrite += RiserTuningLink_OnWrite;
            riserTuningAlarmLevel.OnWrite += RiserTuningLink_OnWrite;
            riserTuningAnalogLevel.OnWrite += RiserTuningLink_OnWrite;

            this.RiserKey = riserKey;
            this.tabNo = tabNo;
            tabControl1.SelectTab(tabNo);
        }

        /// <summary>
        /// Команда для записи новых параметров
        /// </summary>
        /// <param name="address"></param>
        /// <param name="regcount"></param>
        /// <param name="hregs"></param>
        /// <param name="changelogdata"></param>
        private void RiserTuningLink_OnWrite(RiserKey riserKey, int address, int regcount, ushort[] hregs, string[] changelogdata = null)
        {
            if (!Data.Segments.TryGetValue(riserKey.SegmentId, out Channel channel)) return;
            channel.Open();
            if (channel.IsOpen)
            {
                try
                {
                    //TODO: channel.Write(...)
                }
                finally
                {
                    channel.Close();
                }
            }
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
                riserTuningLink.UpdateData(RiserKey, riser.Registers);
                riserTuningPlc.UpdateData(RiserKey, riser.Registers);
                riserTuningAdc.UpdateData(RiserKey, riser.Registers);
                riserTuningAlarmLevel.UpdateData(RiserKey, riser.Registers);
                riserTuningAnalogLevel.UpdateData(RiserKey, riser.Registers);
            }
        }

    }
}
