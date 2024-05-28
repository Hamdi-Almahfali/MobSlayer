using CatmullRom;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal static class LoadPath
    {
        public static void LoadPathFromFile(CatmullRomPath path, string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            { 
                //path.AddPoint(InputParser.parse_Vector2(line));
            }
        }

        //Hoppas över i genomgång.
        public static void SavePathToFile(CatmullRomPath path, string file)
        {
            Vector2[] points = path.GetPoints();
            string[] lines = new string[points.Length];
            for (int i = 0; i < points.Length; i++)
                lines[i] = ((int)(points[i].X)).ToString() + "," + ((int)points[i].Y).ToString();
            System.IO.File.WriteAllLines(file, lines);
        }
    }
}
