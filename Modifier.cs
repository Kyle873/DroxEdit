using System;

namespace DroxEdit
{
    public class Modifier
    {
        public string name = string.Empty;
        public string effect = string.Empty;
        public int id = 0;
        public int rank = 0;
        public int rankMax = 0;

        public void GenerateID()
        {
            id = new Random((int)DateTime.Now.Ticks).Next(Int32.MinValue, Int32.MaxValue);
        }

        public override string ToString()
        {
            return name + " " + rank + " - " + effect;
        }
    }
}
