using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal abstract class Enemy : GameObject
    {
        Vector2 _size;

        int columns;
        int totalFrames;
        float timePerFrame;

        // Actually rectange to draw the sprite
        Rectangle source;

        public Enemy(Vector2 position, Texture2D texture, Vector2 size, int speed) : base(position, texture)
        {
            _size = size;
            Create(size, speed);
        }
        public void Update(GameTime gameTime)
        {
            CalculateFrames(gameTime);
        }
        public void Draw(SpriteBatch sb)
        {
            // Draw the current frame
            sb.Draw(texture, Position, source, Color.White, 0, new Vector2(_size.X / 2, _size.Y / 2), 1, SpriteEffects.None, 0);
        }
        private void Create(Vector2 size, int speed)
        {
            // Calculate the number of frames horizontally and vertically
            columns = texture.Width / (int)size.X;

            // Calculate the total number of frames
            totalFrames = columns;

            // Calculate the frame index based on time and speed
            timePerFrame = 1f / speed;
        }
        private void CalculateFrames(GameTime gameTime)
        {
            int frameIndex = (int)(gameTime.TotalGameTime.TotalSeconds / timePerFrame) % totalFrames;

            // Calculate the source rectangle for the current frame
            source = new Rectangle(frameIndex * (int)_size.X, 0, (int)_size.X, (int)_size.Y);

        }
    }
}
