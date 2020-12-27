using System.Net;

namespace NalivARM10
{
    public class EthernetTuning : Tuning
    {
        public IPAddress Address { get; set; }
        public int Port { get; set; }

        public EthernetTuning(string ipString) : base(ipString)
        {
            Address = IPAddress.Parse(ipString);
            Port = 502;
        }
    }
}
