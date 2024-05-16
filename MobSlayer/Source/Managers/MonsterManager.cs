using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class MonsterManager
    {
        //List<Bat> bats;
        GraphicsDevice gd;
        int timeSinceLastCar = 0;
        int mBetweenCreation = 1500;
        int nrOfCarsInCurrentWave = 10;

        public MonsterManager(GraphicsDevice gd)
        {
            this.gd = gd;
            //bats = new List<Bat>();
        }
        public void LoadWave(GameTime gt)
        {
            timeSinceLastCar += gt.ElapsedGameTime.Milliseconds;
            if (nrOfCarsInCurrentWave > 0 && timeSinceLastCar > mBetweenCreation)
            {
                timeSinceLastCar -= mBetweenCreation;
                //Bat c = new(null, Assets.spr_mob_bat_0, 1, gd);
                //bats.Add(c);
                --nrOfCarsInCurrentWave;
            }
        }

        public void Update(GameTime gt)
        {
            LoadWave(gt);
            //foreach (Bat c in bats)
            //{
            //    c.Update(gt);
            //}
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //foreach (Bat c in bats)
            //{
            //    if (!c.isHit)
            //        c.Draw(spriteBatch);
            //}
            //foreach (Bat c in bats)
            //{
            //    if (!c.isHit)
            //        c.DrawHealth(spriteBatch);
            //}

        }
    }
}
