using NalivARM10.Model;
using NalivARM10.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserTuningLinkControl : UserControl, IFetchUpdate
	{
		public RiserTuningLinkControl()
		{
			InitializeComponent();
		}

        public event WriteData OnWrite;

        private RiserKey riserKey;

        private ushort _hr37;
		private ushort _hr38;
        private int[] _histregs = new int[] {};

        public int NodeType { get; set; }

        public int[] DataFromStorage
        {
        	get { return _histregs; }
        	set 
        	{ 
        		_histregs = value; 
        		if (_histregs.Length != 25) return;
        		_hr37 = Convert.ToUInt16(_histregs[22]);
        		_hr38 = Convert.ToUInt16(_histregs[23]);
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

            lbAddress.Text = GetHRegVector(hregs[0x37], 8, 8).ToString("0");

            var baud = GetHRegVector(hregs[0x37], 0, 4);
            var abaud = new[] { "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "76800", "115200", "230400" };
            lbBaudRate.Text = baud < abaud.Length ? abaud[baud] : "??????";

            var parity = GetHRegVector(hregs[0x37], 4, 2);
            var apar = new[] { "None", "Odd", "Even" };
            lbParity.Text = parity < apar.Length ? apar[parity] : "??????";

            lbHR38.Text = hregs[0x38].ToString("0");
            var frame = (hregs[0x37] & 0x0080) > 0;
            lbModbus.Text = frame ? "RTU" : "ASCII";
            lbHR3A.Text = GetHRegVector(hregs[0x3A], 8, 8) + @"." + GetHRegVector(hregs[0x3A], 0, 8);
            lbHR3B.Text = GetHRegVector(hregs[0x3B], 8, 8) + @"." + GetHRegVector(hregs[0x3B], 0, 8);
            lbHR3C.Text = hregs[0x3C].ToString("0");

            var enabled = true;
            btnCopy.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnCopyFromStorage.Visible = _histregs.Length == 25;
        }

		void BtnCopyFromStorageClick(object sender, EventArgs e)
		{
			edAddress.Text = GetHRegVector(_hr37, 8, 8).ToString("0");
			var baud = GetHRegVector(_hr37, 0, 4);
			switch (baud)
			{
				case 0:
					cbBaudRate.Text = @"1200";
					break;
				case 1:
					cbBaudRate.Text = @"2400";
					break;
				case 2:
					cbBaudRate.Text = @"4800";
					break;
				case 3:
					cbBaudRate.Text = @"9600";
					break;
				case 4:
					cbBaudRate.Text = @"14400";
					break;
				case 5:
					cbBaudRate.Text = @"19200";
					break;
				case 6:
					cbBaudRate.Text = @"28800";
					break;
				case 7:
					cbBaudRate.Text = @"38400";
					break;
				case 8:
					cbBaudRate.Text = @"57600";
					break;
				case 9:
					cbBaudRate.Text = @"76800";
					break;
				case 10:
					cbBaudRate.Text = @"115200";
					break;
				case 11:
					cbBaudRate.Text = @"230400";
					break;
				default:
					cbBaudRate.Text = @"??????";
					break;
			}
			var parity = GetHRegVector(_hr37, 4, 2);
			switch (parity)
			{
				case 0:
					cbParity.Text = @"нет";
					break;
				case 1:
					cbParity.Text = @"нечет";
					break;
				case 2:
					cbParity.Text = @"чет";
					break;
				default:
					cbParity.Text = @"??????";
					break;
			}
			edHR38.Text = _hr38.ToString("0");
		}

        public void UpdateTimeout()
        {
			lbAddress.Text = @"------";
			lbBaudRate.Text = @"------";
			lbParity.Text = @"------";
			lbHR38.Text = @"------";
			lbModbus.Text = @"------";
			lbHR3A.Text = @"------";
			lbHR3B.Text = @"------";
			lbHR3C.Text = @"------";
			btnCopy.Enabled = false;
			btnSave.Enabled = false;
        }
		
		void BtnCopyClick(object sender, EventArgs e)
		{
			edAddress.Text = lbAddress.Text;
			cbBaudRate.Text = lbBaudRate.Text;
			cbParity.Text = lbParity.Text;
			edHR38.Text = lbHR38.Text;
		}
		
        private static int GetHRegVector(int hreg, int lowbit, int bitcount)
        {
            var mask = 0x01;
            for (var i = 1; i < bitcount; i++)
                mask = (mask << 1) | 1;
            return (hreg >> lowbit) & mask;
        }		
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (OnWrite == null) return;
            if (ushort.TryParse(edAddress.Text, out ushort addr) &&
                addr >= 1 && addr <= 247 &&
                ushort.TryParse(edHR38.Text, out ushort hr38) &&
                cbBaudRate.Text.Trim().Length > 0 &&
                cbParity.Text.Trim().Length > 0)
            {
                ushort baud;
                switch (cbBaudRate.Text)
                {
                    case "1200": baud = 0; break;
                    case "2400": baud = 1; break;
                    case "4800": baud = 2; break;
                    case "9600": baud = 3; break;
                    case "14400": baud = 4; break;
                    case "19200": baud = 5; break;
                    case "28800": baud = 6; break;
                    case "38400": baud = 7; break;
                    case "57600": baud = 8; break;
                    case "76800": baud = 9; break;
                    case "115200": baud = 10; break;
                    case "230400": baud = 11; break;
                    default:
                        baud = 3;
                        break;
                }
                ushort parity;
                switch (cbParity.Text)
                {
                    case "None": parity = 0; break;
                    case "Odd": parity = 1; break;
                    case "Even": parity = 2; break;
                    default:
                        parity = 0;
                        break;
                }

                var hregs = new ushort[3];
                hregs[0] = 38;
                hregs[1] = (ushort)(baud + parity * 16 + addr * 256 + 128);
                hregs[2] = hr38;
                OnWrite(riserKey, 0x09, 3, hregs, PrepareForChangeLog());
            }
            else
                MessageBox.Show(this, @"Не все данные заполнены во входных данных!",
                                @"Запись данных настройки связи",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string[] PrepareForChangeLog()
        {
            var list = new List<string>();
            if (lbAddress.Text != edAddress.Text)
                list.Add(string.Concat("ModbusID", "\t", lbAddress.Text, "\t", edAddress.Text, "\t", "Адрес устройства"));
            if (lbBaudRate.Text != cbBaudRate.Text)
                list.Add(string.Concat("Baudrate", "\t", lbBaudRate.Text, "\t", cbBaudRate.Text, "\t", "Скорость обмена"));
            if (lbParity.Text != cbParity.Text)
                list.Add(string.Concat("Parity", "\t", lbParity.Text, "\t", cbParity.Text, "\t", "Паритет"));
            if (lbHR38.Text != edHR38.Text)
                list.Add(string.Concat("HR38", "\t", lbHR38.Text, "\t", edHR38.Text, "\t", "Тайм-аут передачи (мкс)"));
            return list.ToArray();
        }
	}
}
