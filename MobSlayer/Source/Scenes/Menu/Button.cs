using Microsoft.VisualBasic.Devices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MobSlayer
{
    internal class Button
    {
        // Button Base Variables
        string text;
        SpriteFont font;
        Vector2 position;
        Rectangle bounds;
        // Button Extra Variables
        float size;
        Vector2 center;

        MouseState mouseState;

        public Button(string text, SpriteFont font, Vector2 pos)
        {
            this.text = text;
            this.font = font;
            position = pos;

            Vector2 textSize = Assets.fnt_pixel.MeasureString(text);
            bounds = new Rectangle((int)position.X, (int)position.Y, (int)textSize.X, (int)textSize.Y);
            center = new Vector2(bounds.Width / 2, bounds.Height / 2);
        }
        
        public void Update(GameTime gt)
        {
            Rectangle mouseRect = new Rectangle(mouseState.X, mouseState.Y, 1, 1);

            if (bounds.Intersects(mouseRect))
            {
                size = 1.3f;
            }
            else
            {
                size = 1;
            }
        }
        public void Draw(SpriteBatch sb)
        {
            sb.DrawString(font, text, position, Color.White, 0, center, size, SpriteEffects.None, 0);
        }
    }
}
