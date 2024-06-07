using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    public class MonsterManager
    {
        public List<Enemy> enemies;
        GraphicsDevice gd;
        int timeSinceLastMonst = 0;
        int mBetweenCreation = 500;
        int nrOfmonstInCurrentWave = 50;

        public MonsterManager(GraphicsDevice gd)
        {
            this.gd = gd;
            enemies = new List<Enemy>();
        }
        public void LoadWave(GameTime gt)
        {
            timeSinceLastMonst += gt.ElapsedGameTime.Milliseconds;
            if (nrOfmonstInCurrentWave > 0 && timeSinceLastMonst > mBetweenCreation)
            {
                timeSinceLastMonst -= mBetweenCreation;
                StrongBat c = new(1,Main.gsm.gameScene._level.cpath_road.EvaluateAt(0), Assets.tex_enemy_batS, 5, 10);
                enemies.Add(c);
                --nrOfmonstInCurrentWave;
            }
        }

        public void Update(GameTime gt)
        {
            LoadWave(gt);
            foreach (Enemy c in enemies)
            {
                c.Update(gt);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Enemy c in enemies)
            {
                if (!c.IsHit)
                    c.Draw(spriteBatch);
            }

        }
    }
}
