using System;

namespace NalivARM10.Model
{
    /// <summary>
    /// Адрес стояка в системе опроса
    /// </summary>
    public struct RiserKey
    {
        public RiserKey(string overpass, string way, string product, uint number, Guid segmentId, uint nodeAddr, byte func)
        {
            Overpass = overpass;
            Way = way;
            Product = product;
            Number = number;
            SegmentId = segmentId;
            NodeAddr = nodeAddr;
            Func = func;
        }

        public string Overpass { get; set; }
        public string Way { get; set; }
        public string Product { get; set; }
        public uint Number { get; set; }
        public Guid SegmentId { get; set; }
        public uint NodeAddr { get; set; }
        public byte Func { get; set; }
    }
}
