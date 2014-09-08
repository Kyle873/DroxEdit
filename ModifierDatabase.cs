using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DroxEdit
{
    public static class ModifierDatabase
    {
        public static List<Modifier> Modifiers = new List<Modifier>();

        public static bool Init()
        {
            string dataPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Data\Modifiers.dat";

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

                Modifier modifier = new Modifier();
                string name = line.Split('=')[0];
                string[] values = line.Split('=')[1].Split(',');

                // Trim whitespace
                for (int i = 0; i < values.Length; i++)
                    values[i] = values[i].Trim();

                modifier.name = name.Trim('\"');
                modifier.effect = values[1].Trim('\"');
                modifier.rankMax = int.Parse(values[0]);
                Modifiers.Add(modifier);
            }

            return true;
        }
    }
}
