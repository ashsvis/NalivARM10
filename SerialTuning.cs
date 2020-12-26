using System;
using System.IO.Ports;

namespace NalivARM10
{
    public class SerialTuning
    {
        public SerialTuning(string comString)
        {
            var vals = comString.Split(','); //"COM1,9600,N"
            if (vals.Length != 3) return;
            PortName = vals[0];
            if (int.TryParse(vals[1], out int baudrate))
                BaudRate = baudrate;
            if (Enum.TryParse(vals[2], out Parity parity))
                Parity = parity;
        }

        public string PortName { get; internal set; } = "COM1";
        public int BaudRate { get; internal set; }
        public Parity Parity { get; internal set; }
    }
}
