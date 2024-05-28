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
    internal class Level
    {
        CatmullRomPath cpath_road;
        float curve_pos = 0;

        GraphicsDevice gd;

        public Level(GraphicsDevice gd)
        {
            this.gd = gd;
            float tension = 1f;
            cpath_road = new CatmullRomPath(this.gd, tension);

            cpath_road.Clear();

            LoadPath.LoadPathFromFile(cpath_road, "monsterPath1.txt");

            cpath_road.DrawFillSetup(gd, 40, 30, 150);
        }
        public void Draw(SpriteBatch sb)
        {
            //sb.Draw(Assets.bg_ground_tiles_0, new Vector2(0, 0), Color.White);
            //sb.Draw(Assets.bg_ground_tiles_0, new Vector2(0, 450), Color.White);
            sb.End();
            //cpath_road.DrawFill(gd, Assets.texture_road);
            sb.Begin();
            sb.DrawRectangle(new Rectangle(800, 0, 400, 900), Data.HexToColor("#141010"));
        }
    }
}
