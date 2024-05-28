using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
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
        Vector2 position;
        Rectangle bounds;
        // Button Extra Variables
        float size;
        Vector2 center;
        Color color;

        // Delegate
        private Action _delegate;

        // Button constants
        readonly Color unselectedColor = Color.White;
        readonly Color selectedColor = Color.Yellow;

        MouseState mouseState;

        public Button(string text, Vector2 pos, Action @delegate)
        {
            this.text = text;
            position = pos;
            _delegate = @delegate;
        }
        public void Create(ContentManager content)
        {
            color = Color.White;
            StringProperties();
        }
        
        public void Update(GameTime gt)
        {
            mouseState = Mouse.GetState();
            Rectangle mouseRect = new Rectangle(mouseState.X, mouseState.Y, 1, 1);

            if (bounds.Intersects(mouseRect))
            {
                size = MathHelper.Lerp(size, 1.2f, 0.2f);
                color = selectedColor;
                CheckClick(_delegate, mouseState);
            }
            else
            {
                size = 1;
                color = unselectedColor;
            }
        }
        public void Draw(SpriteBatch sb)
        {
            sb.DrawString(Assets.fnt_pixel, text, position / 1.005f + center, Color.Black, 0, center, size, SpriteEffects.None, 0);
            sb.DrawString(Assets.fnt_pixel, text, position + center, color, 0, center, size, SpriteEffects.None, 0);
        }
        public void CheckClick(Action @delegate, MouseState ms)
        {
            if (ms.LeftButton == ButtonState.Pressed)
            {
                _delegate?.Invoke();
            }
        }
        private void StringProperties()
        {
            // Measure the size of the text
            Vector2 textSize = Assets.fnt_pixel.MeasureString(text);
            position = new Vector2(position.X - textSize.X /2, position.Y - textSize.Y /2);
            bounds = new Rectangle((int)position.X, (int)position.Y, (int)textSize.X, (int)textSize.Y / 2);
            center = new Vector2(bounds.Width / 2, bounds.Height / 2);
        }
    }
}
