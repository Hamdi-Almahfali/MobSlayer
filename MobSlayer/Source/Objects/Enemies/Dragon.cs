using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MobSlayer
{
    internal class Dragon : Enemy
    {
        public Dragon(int reward, float moveSpeed, Vector2 position, Texture2D texture, int frameCount, int speed) : base(reward, moveSpeed, position, texture, frameCount, speed)
        {
            _isBoss = true;
            original_curve_speed = moveSpeed / 1.7f;
            curve_speed = original_curve_speed;
            _maxHealth = _maxHealth * 30;
            _health = _maxHealth;
        }
        // Win if dragon is killed
        public override void Kill()
        {
            if (!_isHit)
            {
                Main.gsm.ChangeLevel(GameStateManager.GameState.Win);
            }
        }
        public override void DrawHealth(SpriteBatch sb)
        {
            var maxSize = new Point(70, 2);

            var color = new Color();
            color.R = (byte)MathHelper.Min((510 * (_maxHealth - _health)) / 100, 255);
            color.G = 255;

            var size = maxSize.X * (_health / (float)_maxHealth);
            var position = _position.ToPoint() - new Point(38, -125);

            sb.Draw(Assets.texHP, new Rectangle(position - new Point(1, 1), maxSize + new Point(2, 2)), Color.Black);
            sb.Draw(Assets.texHP, new Rectangle(position, new Point((int)size, maxSize.Y)), color);

        }
    }
}
