using NalivARM10.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserTuningAlarmLevelControl : UserControl, IFetchUpdate
	{
		public RiserTuningAlarmLevelControl()
		{
			InitializeComponent();
		}

        public string IpAddress { get; set; }
        public int IpPort { get; set; }
		public int NodeAddr { get; set; }
        public int NodeType { get; set; }
        
        public event WriteData OnWrite;

		private ushort _hr14;
		private ushort _hr20;
		private ushort _hr21;
		private ushort _hr2C;
		private ushort _hr2D;
		private ushort _hr2E;
		private ushort _hr2F;
        private int[] _histregs = new int[] {};

        public int[] DataFromStorage
        {
        	get { return _histregs; }
        	set 
        	{ 
        		_histregs = value; 
        		if (_histregs.Length != 25) return;
        		_hr14 = Convert.ToUInt16(_histregs[0]);
        		_hr20 = Convert.ToUInt16(_histregs[7]);
        		_hr21 = Convert.ToUInt16(_histregs[8]);
        		_hr2C = Convert.ToUInt16(_histregs[11]);
        		_hr2D = Convert.ToUInt16(_histregs[12]);
        		_hr2E = Convert.ToUInt16(_histregs[13]);
        		_hr2F = Convert.ToUInt16(_histregs[14]);
        	}
        }

        public void UpdateData(ushort[] hregs)
	    {
	        if (hregs == null || hregs.Length != 61)
	        {
	            UpdateTimeout();
	            return;
	        }

            lbHR2C.Text = hregs[0x2C].ToString("0");
            lbHR2D.Text = hregs[0x2D].ToString("0");
            lbHR2E.Text = hregs[0x2E].ToString("0");
            lbHR2F.Text = hregs[0x2F].ToString("0");

            lbHR20.Text = hregs[0x20].ToString("0");
            lbHR21.Text = hregs[0x21].ToString("0");

            lbHR14_8.Text = (hregs[0x14] & 0x0100) > 0 ? "Включена" : "Отключена";
            lbHR14_9.Text = (hregs[0x14] & 0x0200) > 0 ? "Включена" : "Отключена";

            lbHR25.Text = (hregs[0x25] * 0.001).ToString("0.000");

            var enabled = true;
            btnCopy.Enabled = enabled;
            btnEEPROM.Enabled = enabled;
            btnRestore.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnCopyFromStorage.Visible = _histregs.Length == 25;
        }

		void BtnCopyFromStorageClick(object sender, EventArgs e)
		{
			edHR2C.Text = _hr2C.ToString("0");
			edHR2D.Text = _hr2D.ToString("0");
			edHR2E.Text = _hr2E.ToString("0");
			edHR2F.Text = _hr2F.ToString("0");
			edHR20.Text = _hr20.ToString("0");
			edHR21.Text = _hr21.ToString("0");
			cbHR14_8.Text = (_hr14 & 0x0100) > 0 ? "Включена" : "Отключена";
			cbHR14_9.Text = (_hr14 & 0x0200) > 0 ? "Включена" : "Отключена";
		}

        public void UpdateTimeout()
        {
			lbHR2C.Text = @"------";
			lbHR2D.Text = @"------";
			lbHR2E.Text = @"------";
			lbHR2F.Text = @"------";
			lbHR20.Text = @"------";
			lbHR21.Text = @"------";
			lbHR25.Text = @"------";
			lbHR14_8.Text = @"------";
			lbHR14_9.Text = @"------";
			btnCopy.Enabled = false;
			btnEEPROM.Enabled = false;
			btnRestore.Enabled = false;
			btnSave.Enabled = false;
        }
		
		void BtnCopyClick(object sender, EventArgs e)
		{
			edHR2C.Text = lbHR2C.Text;
			edHR2D.Text = lbHR2D.Text;
			edHR2E.Text = lbHR2E.Text;
			edHR2F.Text = lbHR2F.Text;
			edHR20.Text = lbHR20.Text;
			edHR21.Text = lbHR21.Text;
			cbHR14_8.Text = lbHR14_8.Text;
			cbHR14_9.Text = lbHR14_9.Text;
		}
		
		void BtnRestoreClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(0x09, 1, new ushort[] { 3 });
        }
		
		void BtnEepromClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(0x09, 1, new ushort[] { 2 });
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
			if (ushort.TryParse(edHR2C.Text, out ushort hr2C) &&
			    ushort.TryParse(edHR2D.Text, out ushort hr2D) &&
			    ushort.TryParse(edHR2E.Text, out ushort hr2E) &&
			    ushort.TryParse(edHR2F.Text, out ushort hr2F) &&
			    ushort.TryParse(edHR20.Text, out ushort hr20) &&
			    ushort.TryParse(edHR21.Text, out ushort hr21) &&
			    cbHR14_8.Text.Trim().Length > 0 &&
			   	cbHR14_9.Text.Trim().Length > 0)
			{
				var hregs = new ushort[8];
				hregs[0] = 1;
				hregs[1] = hr2C;
				hregs[2] = hr2D;
				hregs[3] = hr2E;
				hregs[4] = hr21;
				hregs[5] = hr20;
				hregs[6] = hr2F;
				ushort flags = 0;
				SetHRegFlag(ref flags, 8, cbHR14_8.Text == @"Включена");
				SetHRegFlag(ref flags, 9, cbHR14_9.Text == @"Включена");
				hregs[7] = flags;
                OnWrite(0x09, 8, hregs, PrepareForChangeLog());
            }
			else
                MessageBox.Show(this, @"Не все данные заполнены во входных данных!", 
				                @"Запись данных для сигнализатора аварийного",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

        private string[] PrepareForChangeLog()
        {
            var list = new List<string>();
            if (lbHR2C.Text != edHR2C.Text)
                list.Add(string.Concat("HR2C", "\t", lbHR2C.Text, "\t", edHR2C.Text, "\t", "Заводской номер сигнализатора аварийного"));
            if (lbHR2D.Text != edHR2D.Text)
                list.Add(string.Concat("HR2D", "\t", lbHR2D.Text, "\t", edHR2D.Text, "\t", "Порог переключения (мкА)"));
            if (lbHR2E.Text != edHR2E.Text)
                list.Add(string.Concat("HR2E", "\t", lbHR2E.Text, "\t", edHR2E.Text, "\t", "Гистерезис переключения (мкА)"));
            if (lbHR2F.Text != edHR2F.Text)
                list.Add(string.Concat("HR2F", "\t", lbHR2F.Text, "\t", edHR2F.Text, "\t", "Задержка переключения (мс)"));
            if (lbHR14_8.Text != cbHR14_8.Text)
                list.Add(string.Concat("HR14.8", "\t", lbHR14_8.Text, "\t", cbHR14_8.Text, "\t", "Инверсия токового сигнала для сигнализатора аварийного"));
            if (lbHR14_9.Text != cbHR14_9.Text)
                list.Add(string.Concat("HR14.9", "\t", lbHR14_9.Text, "\t", cbHR14_9.Text, "\t", "Инверсия релейного сигнала для сигнализатора аварийного"));
            if (lbHR21.Text != edHR21.Text)
                list.Add(string.Concat("HR21", "\t", lbHR21.Text, "\t", edHR21.Text, "\t", "Минимальный ток (мкА) сигнализатора аварийного"));
            if (lbHR20.Text != edHR20.Text)
                list.Add(string.Concat("HR20", "\t", lbHR20.Text, "\t", edHR20.Text, "\t", "Максимальный ток (мкА) сигнализатора аварийного"));
            return list.ToArray();
        }
    }
}
