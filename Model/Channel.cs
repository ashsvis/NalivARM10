using System;

namespace NalivARM10.Model
{
    public abstract class Channel
    {
        protected Channel(string tuning)
        {
        }

        public int WriteTimeout { get; set; } = 5000;
        public int ReadTimeout { get; set; } = 5000;

        public abstract void Open();

        public abstract bool IsOpen { get; protected set; }
        public abstract int BytesToRead { get; }

        public abstract void Close();

        public abstract void Write(byte[] sendBytes, int offset, int length);

        public abstract int ReadByte();
    }
}
