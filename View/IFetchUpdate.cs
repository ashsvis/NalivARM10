using NalivARM10.Model;

namespace NalivARM10.View
{
    public delegate void FetchData(string ipAddr, int ipPort, int node, int address, int regcount);
    public delegate void WriteData(RiserKey riserKey, int address, int regcount, ushort[] hregs, string[] changelogdata = null);

    public interface IFetchUpdate
    {
        void UpdateData(RiserKey riserKey, ushort[] hregs);
        void UpdateTimeout();
        event WriteData OnWrite;
    }
}
