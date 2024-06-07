using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatmullRom;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MobSlayer
{
    public class Level
    {
        public CatmullRomPath cpath_road;
        public float curve_pos = 0;

        GraphicsDevice gd;

        public Level(GraphicsDevice gd)
        {
            this.gd = gd;
            float tension = 0.9f;
            cpath_road = new CatmullRomPath(this.gd, tension);

            cpath_road.Clear();

            LoadPath.LoadPathFromFile(cpath_road, "monsterPath1.txt");

            cpath_road.DrawFillSetup(gd, 34, 50, 200);
        }
        public void Draw(SpriteBatch sb)
        {
            cpath_road.DrawFill(gd, Assets.tex_env_sand0);
        }
    }
}
