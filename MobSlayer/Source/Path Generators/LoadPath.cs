using CatmullRom;
using Microsoft.Xna.Framework;

namespace MobSlayer
{
    internal static class LoadPath
    {
        public static void LoadPathFromFile(CatmullRomPath path, string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                path.AddPoint(Data.parse_Vector2(line));
            }
        }
    }
}
