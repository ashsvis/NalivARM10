using NalivARM10.Model;
using NalivARM10.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NalivARM10
{
	public partial class RiserTuningAdcControl : UserControl, IFetchUpdate
	{
		public RiserTuningAdcControl()
		{
			InitializeComponent();
		}

        public string IpAddress { get; set; }
        public int IpPort { get; set; }
		public int NodeAddr { get; set; }
        public int NodeType { get; set; }
        
        public event WriteData OnWrite;

		private RiserKey riserKey;

		private ushort _hr14;
		private ushort _hr26;
		private ushort _hr27;
        private int[] _histregs = new int[] {};

        public int[] DataFromStorage
        {
        	get { return _histregs; }
        	set 
        	{ 
        		_histregs = value; 
        		if (_histregs.Length != 25) return;
        		_hr14 = Convert.ToUInt16(_histregs[0]);
        		_hr26 = Convert.ToUInt16(_histregs[9]);
        		_hr27 = Convert.ToUInt16(_histregs[10]);
        	}
        }

        public void UpdateData(RiserKey riserKey, ushort[] hregs)
	    {
			this.riserKey = riserKey;

			if (hregs == null || hregs.Length != 61)
	        {
	            UpdateTimeout();
                return;
	        }
            lbHR22.Text = @"0x" + hregs[0x22].ToString("X4");
            lbHR23.Text = @"0x" + hregs[0x23].ToString("X4");
            lbHR24.Text = (hregs[0x24] * 0.001).ToString("0.000");
            lbHR25.Text = (hregs[0x25] * 0.001).ToString("0.000");
            lbHR26.Text = hregs[0x26].ToString("0");
            lbHR27.Text = hregs[0x27].ToString("0");
            lbHR28.Text = @"0x" + hregs[0x28].ToString("X4");
            lbHR29.Text = @"0x" + hregs[0x29].ToString("X4");
            lbHR2A.Text = @"0x" + hregs[0x2A].ToString("X4");
            lbHR2B.Text = @"0x" + hregs[0x2B].ToString("X4");

            lbHR14_0.Text = (hregs[0x14] & 0x0001) > 0 ? "Включен" : "Отключен";
            lbHR14_4.Text = (hregs[0x14] & 0x0010) > 0 ? "Включен" : "Отключен";

            var enabled = true;
            btnCopyADC0.Enabled = enabled;
            btnEEPROMADC0.Enabled = enabled;
            btnRestoreADC0.Enabled = enabled;
            btnSaveADC0.Enabled = enabled;
            btnCopyADC1.Enabled = enabled;
            btnEEPROMADC1.Enabled = enabled;
            btnRestoreADC1.Enabled = enabled;
            btnSaveADC1.Enabled = enabled;
            btnSaveHR28.Enabled = enabled;
            btnSaveHR29.Enabled = enabled;
            btnSaveHR2A.Enabled = enabled;
            btnSaveHR2B.Enabled = enabled;
            btnCopyFromStorage.Visible = _histregs.Length == 25;
        }

        void BtnCopyFromStorageClick(object sender, EventArgs e)
		{
			edHR26.Text = _hr26.ToString("0");
			edHR27.Text = _hr27.ToString("0");
			cbHR14_0.Text = (_hr14 & 0x0001) > 0 ? "Включен" : "Отключен";
			cbHR14_4.Text = (_hr14 & 0x0010) > 0 ? "Включен" : "Отключен";
		}

        public void UpdateTimeout()
        {
			lbHR22.Text = @"------";
			lbHR23.Text = @"------";
			lbHR24.Text = @"------";
			lbHR25.Text = @"------";
			lbHR26.Text = @"------";
			lbHR27.Text = @"------";
			lbHR28.Text = @"------";
			lbHR29.Text = @"------";
			lbHR2A.Text = @"------";
			lbHR2B.Text = @"------";
			lbHR14_0.Text = @"------";
			lbHR14_4.Text = @"------";
			btnCopyADC0.Enabled = false;
			btnEEPROMADC0.Enabled = false;
			btnRestoreADC0.Enabled = false;
			btnSaveADC0.Enabled = false;
			btnCopyADC1.Enabled = false;
			btnEEPROMADC1.Enabled = false;
			btnRestoreADC1.Enabled = false;
			btnSaveADC1.Enabled = false;
			btnSaveHR28.Enabled = false;
			btnSaveHR29.Enabled = false;
			btnSaveHR2A.Enabled = false;
			btnSaveHR2B.Enabled = false;
        }
		
        private static void SetHRegFlag(ref ushort hreg, int bit, bool value)
        {
            if (value)
                hreg |= (ushort)(0x01 << bit);
            else
                hreg &= (ushort)~(0x01 << bit);
        }

		void BtnCopyAdc0Click(object sender, EventArgs e)
		{
			edHR26.Text = lbHR26.Text;
			cbHR14_0.Text = lbHR14_0.Text;
		}
		
		void BtnCopyAdc1Click(object sender, EventArgs e)
		{
			edHR27.Text = lbHR27.Text;
			cbHR14_4.Text = lbHR14_4.Text;
		}
		
		void BtnSaveHr28Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
            OnWrite(riserKey, 0x09, 1, new ushort[] { 9 });
		}
		
		void BtnSaveHr29Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(riserKey, 0x09, 1, new ushort[] { 13 });
        }
		
		void BtnSaveHr2AClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(riserKey, 0x09, 1, new ushort[] { 21 });
        }
		
		void BtnSaveHr2BClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(riserKey, 0x09, 1, new ushort[] { 25 });
        }
		
		void BtnRestoreAdc0Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(riserKey, 0x09, 1, new ushort[] { 19 });
        }
		
		void BtnEepromadc0Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(riserKey, 0x09, 1, new ushort[] { 18 });
        }
		
		void BtnRestoreAdc1Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(riserKey, 0x09, 1, new ushort[] { 31 });
        }
		
		void BtnEepromadc1Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(riserKey, 0x09, 1, new ushort[] { 30 });
        }
		
		void BtnSaveAdc0Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			ushort hr26;
			if (ushort.TryParse(edHR26.Text, out hr26) &&
			   	cbHR14_0.Text.Trim().Length > 0)
			{
				var hregs = new ushort[3];
				hregs[0] = 17;
				hregs[1] = hr26;
				ushort flags = 0;
				SetHRegFlag(ref flags, 0, cbHR14_0.Text == @"Включен");
				hregs[2] = flags;
                OnWrite(riserKey, 0x09, 3, hregs, PrepareForChangeLogChannel0());
            }
			else
                MessageBox.Show(this, @"Не все данные заполнены во входных данных!", 
				                @"Запись данных для настройки ADC0",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

        private string[] PrepareForChangeLogChannel0()
        {
            var list = new List<string>();
            if (lbHR26.Text != edHR26.Text)
                list.Add(string.Concat("HR26", "\t", lbHR26.Text, "\t", edHR26.Text, "\t", "Период выборки (мс) канала 0 (сигнализатор уровня)"));
            if (lbHR14_0.Text != cbHR14_0.Text)
                list.Add(string.Concat("HR14.0", "\t", lbHR14_0.Text, "\t", cbHR14_0.Text, "\t", "Фильтр канала 0 (сигнализатор уровня)"));
            return list.ToArray();
        }
		
		void BtnSaveAdc1Click(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			ushort hr27;
			if (ushort.TryParse(edHR27.Text, out hr27) &&
			   	cbHR14_4.Text.Trim().Length > 0)
			{
				var hregs = new ushort[3];
				hregs[0] = 29;
				hregs[1] = hr27;
				ushort flags = 0;
				SetHRegFlag(ref flags, 4, cbHR14_4.Text == @"Включен");
				hregs[2] = flags;
                OnWrite(riserKey, 0x09, 3, hregs, PrepareForChangeLogChannel1());
            }
			else
                MessageBox.Show(this, @"Не все данные заполнены во входных данных!", 
				                @"Запись данных для настройки ADC1",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

        private string[] PrepareForChangeLogChannel1()
        {
            var list = new List<string>();
            if (lbHR27.Text != edHR27.Text)
                list.Add(string.Concat("HR27", "\t", lbHR27.Text, "\t", edHR27.Text, "\t", "Период выборки (мс) канала 1 (сигнализатор аварийный)"));
            if (lbHR14_4.Text != cbHR14_4.Text)
                list.Add(string.Concat("HR14.4", "\t", lbHR14_4.Text, "\t", cbHR14_4.Text, "\t", "Фильтр канала 1 (сигнализатор аварийный)"));
            return list.ToArray();
        }
    }
}
