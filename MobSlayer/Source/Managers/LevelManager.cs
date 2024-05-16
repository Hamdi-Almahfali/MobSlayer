using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class LevelManager
    {
        List<Level> levels;

        public LevelManager()
        {
            levels = new();
        }

        public void CreateLevel(GraphicsDevice gd)
        {
            levels.Add(new Level(gd));
        }
        public void Draw(SpriteBatch sb, int lvl)
        {
            levels[lvl].Draw(sb);
        }
    }
}
