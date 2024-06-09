using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MobSlayer
{
    /// <summary>
    /// The particle that gets spawned and controlled by the emitter
    /// </summary>
    public class Particle
    {
        Texture2D texture;
        Vector2 position;
        Vector2 velocity;
        float timeLeft;
        float initialTimeLeft;
        float rotation;
        bool rotate;

        public bool IsAlive => timeLeft > 0;

        public Particle(Texture2D texture, Vector2 position, Vector2 velocity, float timeLeft, bool rotate)
        {
            this.texture = texture;
            this.position = position - new Vector2(texture.Width / 2, texture.Height / 2);
            this.velocity = velocity;
            this.timeLeft = timeLeft;
            this.initialTimeLeft = timeLeft;
            this.rotate = rotate;
            if (!rotate)
                return;
            Random random = new Random();
            rotation = random.Next(360);
        }

        public void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            timeLeft -= deltaTime;
            position += velocity * deltaTime;
            velocity *= 0.99f; // Damping to slow down over time, simulating air resistance
        }

        public void Draw(SpriteBatch spriteBatch, Color? extraColor)
        {
            float alpha = MathHelper.Clamp(timeLeft / initialTimeLeft, 0, 1);
            Color color;
            if (extraColor != null)
                color = (Color)extraColor * alpha;
            else
                color = Color.White * alpha;

            var newPos = new Vector2(position.X + texture.Width / 2, position.Y + texture.Height / 2);
            spriteBatch.Draw(texture, newPos, null, color, rotation, Vector2.Zero, 1, SpriteEffects.None, 0);
        }
    }
}

