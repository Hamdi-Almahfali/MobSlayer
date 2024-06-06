using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class CustomTimer
    {
        private double currentTime = 0.0;
        public void ResetAndStart(double delay)
        {
            currentTime = delay;
        }
        public bool IsDone()
        {
            return currentTime <= 0.0;
        }
        public void Update(GameTime gt)
        {
            var deltaTime = gt.ElapsedGameTime.TotalSeconds;
            currentTime -= deltaTime;
        }
    }
}
