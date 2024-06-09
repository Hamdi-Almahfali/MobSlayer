using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MobSlayer
{
    internal class WeakBat : Enemy
    {
        public WeakBat(int reward, float moveSpeed, Vector2 position, Texture2D texture, int frameCount, int speed) : base(reward, moveSpeed, position, texture, frameCount, speed)
        {
            original_curve_speed = moveSpeed * 3;
            curve_speed = original_curve_speed;
            _maxHealth = _maxHealth / 2;
            _health = _maxHealth;
        }
    }
}
