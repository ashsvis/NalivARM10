using System.Collections.Concurrent;

namespace NalivARM10.Model
{
    public static class Data
    {
        public static ConcurrentDictionary<RiserKey, Riser> Risers = new ConcurrentDictionary<RiserKey, Riser>();
    }
}
