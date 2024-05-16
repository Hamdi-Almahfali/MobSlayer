using CatmullRom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal static class LoadPath
    {
        public static void LoadPathFromFile(CatmullRomPath path, string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                //path.AddPoint(InputParser.parse_Vector2(line));
            }
        }
    }
}
