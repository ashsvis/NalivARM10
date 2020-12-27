﻿namespace NalivARM10.Model
{
    public class Riser
    {
        public string OverpassId { get; set; }
        public string WayId { get; set; }
        public string ProductId { get; set; }
        public uint Number { get; set; }
        public byte NodeAddr { get; set; }

        public int Level { get; set; }
    }
}
