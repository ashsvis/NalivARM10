using NalivARM10.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserTuningPlcControl : UserControl, IFetchUpdate
	{
		public RiserTuningPlcControl()
		{
			InitializeComponent();
		}

        public string IpAddress { get; set; }
        public int IpPort { get; set; }
		public int NodeAddr { get; set; }
        public int NodeType { get; set; }
        
        public event WriteData OnWrite;

        private ushort _hr14;
		private ushort _hr19;
		private ushort _hr1A;
		private ushort _hr1B;
		private ushort _hr1C;
		private ushort _hr39;
        private int[] _histregs = new int[] {};

        public int[] DataFromStorage
        {
        	get { return _histregs; }
        	set 
        	{ 
        		_histregs = value; 
        		if (_histregs.Length != 25) return;
        		_hr14 = Convert.ToUInt16(_histregs[0]);
        		_hr19 = Convert.ToUInt16(_histregs[1]);
        		_hr1A = Convert.ToUInt16(_histregs[2]);
        		_hr1B = Convert.ToUInt16(_histregs[3]);
        		_hr1C = Convert.ToUInt16(_histregs[4]);
        		_hr39 = Convert.ToUInt16(_histregs[24]);
        	}
        }

        public void UpdateData(ushort[] hregs)
	    {
	        if (hregs == null || hregs.Length != 61)
	        {
	            UpdateTimeout();
	            return;
	        }

            lbHR1A.Text = hregs[0x1A].ToString("0");
            lbHR1B.Text = hregs[0x1B].ToString("0");
            lbHR1C.Text = hregs[0x1C].ToString("0");
            lbHR1D.Text = hregs[0x1D].ToString("0");

            lbHR19.Text = hregs[0x19].ToString("0");

            lbHR39.Text = hregs[0x39].ToString("0");

            lbHR14_2.Text = (hregs[0x14] & 0x0004) > 0 ? "Да" : "Нет";
            lbHR14_3.Text = (hregs[0x14] & 0x0008) > 0 ? "Разрешена" : "Запрещена";
            lbHR14_6.Text = (hregs[0x14] & 0x0040) > 0 ? "Запрещен" : "Разрешен";
            lbHR14_7.Text = (hregs[0x14] & 0x0080) > 0 ? "Включена" : "Отключена";

            var enabled = true; // Data.UserLevel >= UserLevel.Oper && !remoted;
            btnCopy.Enabled = enabled;
            btnEEPROM.Enabled = enabled;
            btnRestore.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnCopyFromStorage.Visible = _histregs.Length == 25;        
        }

        /*
	    public void UpdateData(int addr, int regcount, ushort[] hregs)
        {
			if (addr == 0x1A && regcount == 4)
			{
				lbHR1A.Text = hregs[0].ToString("0");
				lbHR1B.Text = hregs[1].ToString("0");
				lbHR1C.Text = hregs[2].ToString("0");
				lbHR1D.Text = hregs[3].ToString("0");
			}
			else
			if (addr == 0x19 && regcount == 1)
			{
				lbHR19.Text = hregs[0].ToString("0");
			}
			else
			if (addr == 0x39 && regcount == 1)
			{
				lbHR39.Text = hregs[0].ToString("0");
			}
			else
			if (addr == 0x14 && regcount == 1)
			{
				lbHR14_2.Text = (hregs[0] & 0x0004) > 0 ? "Да" : "Нет";
				lbHR14_3.Text = (hregs[0] & 0x0008) > 0 ? "Разрешена" : "Запрещена";
				lbHR14_6.Text = (hregs[0] & 0x0040) > 0 ? "Запрещен" : "Разрешен";
				lbHR14_7.Text = (hregs[0] & 0x0080) > 0 ? "Включена" : "Отключена";
			}
			btnCopy.Enabled = true;
			btnEEPROM.Enabled = true;
			btnRestore.Enabled = true;
			btnSave.Enabled = true;
       		btnCopyFromStorage.Visible = _histregs.Length == 25;
        }
		*/

        void BtnCopyFromStorageClick(object sender, EventArgs e)
		{
			edHR1A.Text = _hr1A.ToString("0");
			edHR1B.Text = _hr1B.ToString("0");
			edHR1C.Text = _hr1C.ToString("0");
			edHR19.Text = _hr19.ToString("0");
			edHR39.Text = _hr39.ToString("0");
			cbHR14_2.Text = (_hr14 & 0x0004) > 0 ? "Да" : "Нет";
			cbHR14_3.Text = (_hr14 & 0x0008) > 0 ? "Разрешена" : "Запрещена";
			cbHR14_6.Text = (_hr14 & 0x0040) > 0 ? "Запрещен" : "Разрешен";
			cbHR14_7.Text = (_hr14 & 0x0080) > 0 ? "Включена" : "Отключена";
		}

        public void UpdateTimeout()
        {
			lbHR1A.Text = @"------";
			lbHR1B.Text = @"------";
			lbHR1C.Text = @"------";
			lbHR1D.Text = @"------";
			lbHR19.Text = @"------";
			lbHR39.Text = @"------";
			lbHR14_2.Text = @"------";
			lbHR14_3.Text = @"------";
			lbHR14_6.Text = @"------";
			lbHR14_7.Text = @"------";
			btnCopy.Enabled = false;
			btnEEPROM.Enabled = false;
			btnRestore.Enabled = false;
			btnSave.Enabled = false;
        }
		
/*
		void TimerFetchTick(object sender, EventArgs e)
		{
			if (OnFetch == null) return;
			OnFetch(IpAddress, IpPort, NodeAddr, 0x1A, 4);
			OnFetch(IpAddress, IpPort, NodeAddr, 0x39, 1);
			OnFetch(IpAddress, IpPort, NodeAddr, 0x19, 1);
			OnFetch(IpAddress, IpPort, NodeAddr, 0x14, 1);
		}
*/
		
		void BtnCopyClick(object sender, EventArgs e)
		{
			edHR1A.Text = lbHR1A.Text;
			edHR1B.Text = lbHR1B.Text;
			edHR1C.Text = lbHR1C.Text;
			edHR19.Text = lbHR19.Text;
			edHR39.Text = lbHR39.Text;
			cbHR14_2.Text = lbHR14_2.Text;
			cbHR14_3.Text = lbHR14_3.Text;
			cbHR14_6.Text = lbHR14_6.Text;
			cbHR14_7.Text = lbHR14_7.Text;
		}
		
		void BtnRestoreClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(0x09, 1, new ushort[] { 35 });
        }
		
		void BtnEepromClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
			OnWrite(0x09, 1, new ushort[] { 34 });
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
			if (ushort.TryParse(edHR1A.Text, out ushort hr1A) &&
			    ushort.TryParse(edHR1B.Text, out ushort hr1B) &&
			    ushort.TryParse(edHR1C.Text, out ushort hr1C) &&
			    ushort.TryParse(edHR19.Text, out ushort hr19) &&
			    ushort.TryParse(edHR39.Text, out ushort  hr39) &&
			    cbHR14_2.Text.Trim().Length > 0 &&
			    cbHR14_3.Text.Trim().Length > 0 &&
			    cbHR14_6.Text.Trim().Length > 0 &&
			   	cbHR14_7.Text.Trim().Length > 0)
			{
				var hregs = new ushort[7];
				hregs[0] = 33;
				hregs[1] = hr19;
				hregs[2] = hr1C;
				hregs[3] = hr1B;
				hregs[4] = hr1A;
				hregs[5] = hr39;
				ushort flags = 0;
				SetHRegFlag(ref flags, 2, cbHR14_2.Text == @"Да");
				SetHRegFlag(ref flags, 3, cbHR14_3.Text == @"Разрешена");
				SetHRegFlag(ref flags, 6, cbHR14_6.Text == @"Запрещен");
				SetHRegFlag(ref flags, 7, cbHR14_7.Text == @"Включена");
				hregs[6] = flags;
                OnWrite(0x09, 7, hregs, PrepareForChangeLog());
            }
			else
                MessageBox.Show(this, @"Не все данные заполнены во входных данных!", 
				                @"Запись данных настройки PLC",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

        private string[] PrepareForChangeLog()
        {
            var list = new List<string>();
            if (lbHR19.Text != edHR19.Text)
                list.Add(string.Concat("HR19", "\t", lbHR19.Text, "\t", edHR19.Text, "\t", "Период логики (мс)"));
            if (lbHR14_2.Text != cbHR14_2.Text)
                list.Add(string.Concat("HR14.2", "\t", lbHR14_2.Text, "\t", cbHR14_2.Text, "\t", "Клапан с герконами состояния"));
            if (lbHR1C.Text != edHR1C.Text)
                list.Add(string.Concat("HR1C", "\t", lbHR1C.Text, "\t", edHR1C.Text, "\t", "Время ожидания герконов (мс)"));
            if (lbHR1B.Text != edHR1B.Text)
                list.Add(string.Concat("HR1B", "\t", lbHR1B.Text, "\t", edHR1B.Text, "\t", "Включение большого клапана (мс)"));
            if (lbHR1A.Text != edHR1A.Text)
                list.Add(string.Concat("HR1A", "\t", lbHR1A.Text, "\t", edHR1A.Text, "\t", "Отключение большого клапана (мм)"));
            if (lbHR14_3.Text != cbHR14_3.Text)
                list.Add(string.Concat("HR14.3", "\t", lbHR14_3.Text, "\t", cbHR14_3.Text, "\t", "Работа при потере связи"));
            if (lbHR39.Text != edHR39.Text)
                list.Add(string.Concat("HR39", "\t", lbHR39.Text, "\t", edHR39.Text, "\t", "Потеря связи (мс)"));
            if (lbHR14_6.Text != cbHR14_6.Text)
                list.Add(string.Concat("HR14.6", "\t", lbHR14_6.Text, "\t", cbHR14_6.Text, "\t", "Контроль заземления"));
            if (lbHR14_7.Text != cbHR14_7.Text)
                list.Add(string.Concat("HR14.7", "\t", lbHR14_7.Text, "\t", cbHR14_7.Text, "\t", "Инверсия контроля заземления"));
            return list.ToArray();
        }
    }
}
