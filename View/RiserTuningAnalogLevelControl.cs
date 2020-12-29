using NalivARM10.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserTuningAnalogLevelControl : UserControl, IFetchUpdate
	{
		public RiserTuningAnalogLevelControl()
		{
			InitializeComponent();
		}

        public string IpAddress { get; set; }
        public int IpPort { get; set; }
		public int NodeAddr { get; set; }
        public int NodeType { get; set; }
        
        public event WriteData OnWrite;

		private ushort _hr14;
		private ushort _hr1E;
		private ushort _hr1F;
		private ushort _hr30;
		private ushort _hr31;
		private ushort _hr32;
		private ushort _hr33;
		private ushort _hr34;
		private ushort _hr35;
		private ushort _hr36;
        private int[] _histregs = new int[] {};

        public int[] DataFromStorage
        {
        	get { return _histregs; }
        	set 
        	{ 
        		_histregs = value; 
        		if (_histregs.Length != 25) return;
        		_hr14 = Convert.ToUInt16(_histregs[0]);
        		_hr1E = Convert.ToUInt16(_histregs[5]);
        		_hr1F = Convert.ToUInt16(_histregs[6]);
        		_hr30 = Convert.ToUInt16(_histregs[15]);
        		_hr31 = Convert.ToUInt16(_histregs[16]);
        		_hr32 = Convert.ToUInt16(_histregs[17]);
        		_hr33 = Convert.ToUInt16(_histregs[18]);
        		_hr34 = Convert.ToUInt16(_histregs[19]);
        		_hr35 = Convert.ToUInt16(_histregs[20]);
        		_hr36 = Convert.ToUInt16(_histregs[21]);
        	}
        }

        public void UpdateData(ushort[] hregs)
        {
            if (hregs == null || hregs.Length != 61)
            {
                UpdateTimeout();
                return;
            }

            lbHR30.Text = hregs[0x30].ToString("0");
            lbHR31.Text = hregs[0x31].ToString("0");
            lbHR32.Text = hregs[0x32].ToString("0");
            lbHR33.Text = hregs[0x33].ToString("0");
            lbHR34.Text = hregs[0x34].ToString("0");
            lbHR35.Text = hregs[0x35].ToString("0");
            lbHR36.Text = hregs[0x36].ToString("0");

            lbHR1E.Text = hregs[0x1E].ToString("0");
            lbHR1F.Text = hregs[0x1F].ToString("0");

            lbHR14_11.Text = (hregs[0x14] & 0x0800) > 0 ? "Крышка" : "Датчик";
            lbHR14_10.Text = (hregs[0x14] & 0x0400) > 0 ? "Включена" : "Отключена";

            lbHR24.Text = (hregs[0x24] * 0.001).ToString("0.000");

            var enabled = true;
            btnCopy.Enabled = enabled;
            btnEEPROM.Enabled = enabled;
            btnRestore.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnCopyFromStorage.Visible = _histregs.Length == 25;
        }
        
        void BtnCopyFromStorageClick(object sender, EventArgs e)
		{
			edHR30.Text = _hr30.ToString("0");
			edHR31.Text = _hr31.ToString("0");
			edHR32.Text = _hr32.ToString("0");
			edHR33.Text = _hr33.ToString("0");
			edHR34.Text = _hr34.ToString("0");
			edHR35.Text = _hr35.ToString("0");
			edHR36.Text = _hr36.ToString("0");
			edHR1E.Text = _hr1E.ToString("0");
			edHR1F.Text = _hr1F.ToString("0");
			cbHR14_11.Text = (_hr14 & 0x0800) > 0 ? "Крышка" : "Датчик";
			cbHR14_10.Text = (_hr14 & 0x0400) > 0 ? "Включена" : "Отключена";
		}

        public void UpdateTimeout()
        {
			lbHR30.Text = @"------";
			lbHR31.Text = @"------";
			lbHR32.Text = @"------";
			lbHR33.Text = @"------";
			lbHR34.Text = @"------";
			lbHR35.Text = @"------";
			lbHR36.Text = @"------";
			lbHR1E.Text = @"------";
			lbHR1F.Text = @"------";
			lbHR14_11.Text = @"------";
			lbHR14_10.Text = @"------";
			lbHR24.Text = @"------";
			btnCopy.Enabled = false;
			btnEEPROM.Enabled = false;
			btnRestore.Enabled = false;
			btnSave.Enabled = false;
        }
		
		void BtnCopyClick(object sender, EventArgs e)
		{
			edHR30.Text = lbHR30.Text;
			edHR31.Text = lbHR31.Text;
			edHR32.Text = lbHR32.Text;
			edHR33.Text = lbHR33.Text;
			edHR34.Text = lbHR34.Text;
			edHR35.Text = lbHR35.Text;
			edHR36.Text = lbHR36.Text;
			edHR1E.Text = lbHR1E.Text;
			edHR1F.Text = lbHR1F.Text;
			cbHR14_11.Text = lbHR14_11.Text;
			cbHR14_10.Text = lbHR14_10.Text;
		}
		
		void BtnRestoreClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(0x09, 1, new ushort[] { 7 });
        }
		
		void BtnEepromClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(0x09, 1, new ushort[] { 6 });
        }
		
        private static void SetHRegFlag(ref ushort hreg, int bit, bool value)
        {
            if (value)
                hreg |= (ushort)(0x01 << bit);
            else
                hreg &= (ushort)~(0x01 << bit);
        }

		void BtnSaveClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			if (ushort.TryParse(edHR30.Text, out ushort hr30) &&
			    ushort.TryParse(edHR31.Text, out ushort hr31) &&
			    ushort.TryParse(edHR32.Text, out ushort hr32) &&
			    ushort.TryParse(edHR33.Text, out ushort hr33) &&
			    ushort.TryParse(edHR34.Text, out ushort hr34) &&
			    ushort.TryParse(edHR35.Text, out ushort hr35) &&
			    ushort.TryParse(edHR36.Text, out ushort hr36) &&
			    ushort.TryParse(edHR1E.Text, out ushort hr1E) &&
			    ushort.TryParse(edHR1F.Text, out ushort hr1F) &&
			    cbHR14_10.Text.Trim().Length > 0 &&
			   	cbHR14_11.Text.Trim().Length > 0)
			{
				var hregs = new ushort[11];
				hregs[0] = 5;
				hregs[1] = hr30;
				hregs[2] = hr31;
				hregs[3] = hr32;
				hregs[4] = hr33;
				hregs[5] = hr34;
				hregs[6] = hr35;
				hregs[7] = hr1F;
				hregs[8] = hr1E;
				hregs[9] = hr36;
				ushort flags = 0;
				SetHRegFlag(ref flags, 11, cbHR14_11.Text == @"Крышка");
				SetHRegFlag(ref flags, 10, cbHR14_10.Text == @"Включена");
				hregs[10] = flags;
                OnWrite(0x09, 11, hregs, PrepareForChangeLog());
            }
			else
                MessageBox.Show(this, @"Не все данные заполнены во входных данных!", 
				                @"Запись данных для сигнализатора уровня",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

        private string[] PrepareForChangeLog()
        {
            var list = new List<string>();
            if (lbHR30.Text != edHR30.Text)
                list.Add(string.Concat("HR30", "\t", lbHR30.Text, "\t", edHR30.Text, "\t", "Заводской номер сигнализатора уровня"));
            if (lbHR31.Text != edHR31.Text)
                list.Add(string.Concat("HR31", "\t", lbHR31.Text, "\t", edHR31.Text, "\t", "Контрольная точка 1 (мм)"));
            if (lbHR32.Text != edHR32.Text)
                list.Add(string.Concat("HR32", "\t", lbHR32.Text, "\t", edHR32.Text, "\t", "Контрольная точка 1 (мкА)"));
            if (lbHR33.Text != edHR33.Text)
                list.Add(string.Concat("HR33", "\t", lbHR33.Text, "\t", edHR33.Text, "\t", "Контрольная точка 2 (мм)"));
            if (lbHR34.Text != edHR34.Text)
                list.Add(string.Concat("HR34", "\t", lbHR34.Text, "\t", edHR34.Text, "\t", "Контрольная точка 2 (мкА)"));
            if (lbHR35.Text != edHR35.Text)
                list.Add(string.Concat("HR35", "\t", lbHR35.Text, "\t", edHR35.Text, "\t", "Глубина установки (мм) сигнализатора уровня"));
            if (lbHR36.Text != edHR36.Text)
                list.Add(string.Concat("HR36", "\t", lbHR36.Text, "\t", edHR36.Text, "\t", "Рабочая длина (мм) сигнализатора уровня"));
            if (lbHR14_11.Text != cbHR14_11.Text)
                list.Add(string.Concat("HR14.11", "\t", lbHR14_11.Text, "\t", cbHR14_11.Text, "\t", "Источник тока для сигнализатора уровня"));
            if (lbHR1F.Text != edHR1F.Text)
                list.Add(string.Concat("HR1F", "\t", lbHR1F.Text, "\t", edHR1F.Text, "\t", "Минимальный ток (мкА) сигнализатора уровня"));
            if (lbHR1E.Text != edHR1E.Text)
                list.Add(string.Concat("HR1E", "\t", lbHR1E.Text, "\t", edHR1E.Text, "\t", "Максимальный ток (мкА) сигнализатора уровня"));
            if (lbHR14_10.Text != cbHR14_10.Text)
                list.Add(string.Concat("HR14.10", "\t", lbHR14_10.Text, "\t", cbHR14_10.Text, "\t", "Инверсия релейного сигнала для сигнализатора уровня"));
            return list.ToArray();
        }
    }
}
