using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
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

            labMessage.Text = "";
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
            if (!channel.IsOpen) return;
            var sendBytes = Channel.PrepareWriteRequest(riserKey, address, regcount, hregs);
            var buff = new List<byte>();
            lock (channel)
            {
                channel.Write(sendBytes, 0, sendBytes.Length);
                Thread.Sleep(100);
                var bytesToRead = channel.BytesToRead;
                if (bytesToRead == 8 || bytesToRead == 5)
                {
                    while (bytesToRead-- > 0)
                        buff.Add((byte)channel.ReadByte());
                }
            }
            if (buff.Count == 8)
            {
                labMessage.Text = "Изменение внесено.";
            }
            else if (buff.Count == 5)
            {
                labMessage.Text = $"Код ошибки: {buff[2]}";
            }
            else
            {
                labMessage.Text = "Нет ответа.";
            }
            timer2.Enabled = true;
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
            UpdateInteface();
        }

        private async void UpdateInteface()
        {
            if (!Data.Segments.TryGetValue(RiserKey.SegmentId, out Channel channel)) return;
            if (!channel.IsOpen) return;
            if (!Data.Risers.TryGetValue(RiserKey, out Riser riser)) return;
            var fetchvals = await Channel.FetchAsync(channel, RiserKey, 0, 61);

            riser.Update(fetchvals);

            Text = $"Стояк №{riser.Key.Number}";
            riserTuningLink.UpdateData(RiserKey, riser.Registers);
            riserTuningPlc.UpdateData(RiserKey, riser.Registers);
            riserTuningAdc.UpdateData(RiserKey, riser.Registers);
            riserTuningAlarmLevel.UpdateData(RiserKey, riser.Registers);
            riserTuningAnalogLevel.UpdateData(RiserKey, riser.Registers);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            labMessage.Text = "";
        }
    }
}
