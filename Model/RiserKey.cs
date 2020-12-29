namespace NalivARM10.Model
{
    /// <summary>
    /// Адрес стояка в системе опроса
    /// </summary>
    public struct RiserKey
    {
        public RiserKey(string overpass, string way, string product, uint number, uint nodeAddr)
        {
            Overpass = overpass;
            Way = way;
            Product = product;
            Number = number;
            NodeAddr = nodeAddr;
        }

        public string Overpass { get; set; }
        public string Way { get; set; }
        public string Product { get; set; }
        public uint Number { get; set; }
        public uint NodeAddr { get; set; }
    }
}
