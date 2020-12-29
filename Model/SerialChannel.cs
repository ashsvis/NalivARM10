using System;
using System.IO.Ports;

namespace NalivARM10.Model
{
    public class SerialChannel : Channel, IDisposable
    {
        private readonly SerialPort port;

        public SerialChannel(string tuning) : base(tuning)
        {
            port = new SerialPort();
            var vals = tuning.Split(','); //"COM1,9600,N"
            if (vals.Length != 3) return;
            PortName = vals[0];
            if (int.TryParse(vals[1], out int baudrate))
                BaudRate = baudrate;
            if (Enum.TryParse(vals[2], out Parity parity))
                Parity = parity;
        }

        ~SerialChannel()
        {
            Dispose();
        }

        public override void Open()
        {
            port.PortName = PortName;
            port.BaudRate = BaudRate;
            port.Parity = Parity;
            port.StopBits = StopBits;
            try
            {
                port.Open();
                IsOpen = true;
            }
            catch
            {
                IsOpen = false;
            }
        }

        public override void Close()
        {
            port.Close();
        }

        public string PortName { get; set; } = "COM1";
        public int BaudRate { get; set; } = 9600;
        public Parity Parity { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.Two;

        public override bool IsOpen { get; protected set; }
        public override int BytesToRead { get => port.BytesToRead; }

        public void Dispose()
        {
            port.Dispose();
        }

        public override void Write(byte[] sendBytes, int offset, int length)
        {
            port.Write(sendBytes, offset, length);
        }

        public override int ReadByte()
        {
            return port.ReadByte();
        }
    }
}
