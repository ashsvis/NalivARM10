using System.Net;

namespace NalivARM10
{
    public class EthernetTuning
    {
        public IPAddress Address { get; set; }
        public int Port { get; set; }

        public EthernetTuning(string ipString)
        {
            Address = IPAddress.Parse(ipString);
            Port = 502;
        }
    }
}
