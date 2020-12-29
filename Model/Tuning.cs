using NalivARM10.Model;
using System;
using System.Collections.Generic;

namespace NalivARM10
{
    public class Tuning
    {
        public Guid SegmentId { get; set; }
        public List<RiserKey> RiserKeys = new List<RiserKey>();

        public Tuning(string tuning) { }
    }
}
