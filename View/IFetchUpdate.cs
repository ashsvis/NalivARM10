namespace NalivARM10.View
{
    public delegate void FetchData(string ipAddr, int ipPort, int node, int address, int regcount);
    public delegate void WriteData(int address, int regcount, ushort[] hregs, string[] changelogdata = null);

    public interface IFetchUpdate
    {
        void UpdateData(ushort[] hregs);
        void UpdateTimeout();
        event WriteData OnWrite;
    }
}
