using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DroxEdit
{
    public static class ItemDatabase
    {
        public static List<Item> Items = new List<Item>();

        public static bool Init()
        {
            string dataPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Data\Items.dat";

            if (!File.Exists(dataPath))
                return false;

            string[] lines = File.ReadAllLines(dataPath);

            foreach (string line in lines)
            {
                // Skip comments
                if (line.StartsWith("//"))
                    continue;

                // Skip blank lines
                if (line.Length == 0)
                    continue;
                
                Item item = new Item();
                string type = line.Split('=')[0];
                string[] values = line.Split('=')[1].Split(',');

                // Trim whitespace
                for (int i = 0; i < values.Length; i++)
                    values[i] = values[i].Trim();

                item.type = type;
                item.name = values[1].Trim('\"');
                item.rank = 1;
                item.rankMax = int.Parse(values[0]);
                item.imageKey = values[2].Trim('\"');
                Items.Add(item);
            }

            return true;
        }
    }
}
