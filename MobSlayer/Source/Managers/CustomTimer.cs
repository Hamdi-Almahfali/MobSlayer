using Microsoft.Xna.Framework;

namespace MobSlayer
{
    /// <summary>
    /// Simple timer class for cooldowns
    /// </summary>
    public class CustomTimer
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
