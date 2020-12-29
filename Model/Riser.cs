namespace NalivARM10.Model
{
    public class Riser
    {
        public RiserKey Key { get; set; }

        public ushort[] Registers { get; private set; }

        public void Update(ushort[] fetchvals)
        {
            this.Registers = fetchvals;
        }
    }
}
