using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NalivARM10.Model
{
    public class Riser
    {
        public Guid OverpassId { get; set; }
        public Guid ProductId { get; set; }
        public uint Number { get; set; }
        public byte NodeAddr { get; set; }
    }
}
