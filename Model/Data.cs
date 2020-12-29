using System;
using System.Collections.Concurrent;

namespace NalivARM10.Model
{
    public static class Data
    {
        public static ConcurrentDictionary<Guid, Channel> Segments = new ConcurrentDictionary<Guid, Channel>();
        public static ConcurrentDictionary<RiserKey, Riser> Risers = new ConcurrentDictionary<RiserKey, Riser>();
    }
}
