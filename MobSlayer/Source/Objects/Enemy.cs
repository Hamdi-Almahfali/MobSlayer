using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CatmullRom;
using System.Windows.Forms;
using System.Diagnostics;

namespace MobSlayer
{
    public abstract class Enemy : GameObject
    {
        int columns;
        int totalFrames;
        float timePerFrame;
        int frameWidth; // Width of each frame
        int frameHeight; // Height of each frame

        protected int reward;

        protected CatmullRomPath cpath_moving;
        protected float curve_curpos = 0;
        float curve_speed = 0.1f;

        protected int _pathIndex;

        protected int _maxHealth = 10;
        protected int _health = 10;

        protected bool _isHit;

        public bool IsHit { get { return _isHit; } }
        public int Health { get { return _health; } set { _health = value; } }

        // Actually rectange to draw the sprite
        Rectangle source;

        public Enemy(int reward, float moveSpeed, Vector2 position, Texture2D texture, int frameCount, int speed) : base(position, texture)
        {
            _hitbox.X = (int)position.X;
            _hitbox.Y = (int)position.Y;
            curve_speed = moveSpeed;
            CalculateFrames(frameCount, speed);
            float tension = 0.9f;
            cpath_moving = new(Main.graphics.GraphicsDevice, tension);
            cpath_moving.Clear();
            LoadPath.LoadPathFromFile(cpath_moving, "monsterPath1.txt");

            cpath_moving.DrawFillSetup(Main.graphics.GraphicsDevice, 34, 50, 200);
            this.reward = reward;
        }

        public void Update(GameTime gt)
        {
            Debug.Print(Main.gsm.gameScene._monsterManager.CurrentWave.nrOfmonstInCurrentWave.ToString());
            if (_isHit)
                return;
            _position.X = _hitbox.X;
            _position.Y = _hitbox.Y;

            CalculateFrames(gt);
            curve_curpos += curve_speed * (float)gt.ElapsedGameTime.TotalSeconds;
            if (curve_curpos < 1 & curve_curpos > 0)
            {
                Vector2 vec = cpath_moving.EvaluateAt(curve_curpos);
                _hitbox.X = (int)vec.X;
                _hitbox.Y = (int)vec.Y;

                Position = vec;
            }
            if (curve_curpos >= 1)
            {
                DamagePlayer();
            }
            // Kill if health below 0
            if (_health <= 0)
                Kill();
        }
        public void Draw(SpriteBatch sb)
        {
            // Draw the current frame
            if (_texture == null)
                return;
            var level = Main.gsm.gameScene._level;
            if (curve_curpos < 1 & curve_curpos > 0)
            {
                var center = new Vector2(_texture.Width / 2, _texture.Height / 2);
                sb.Draw(_texture, _position, source, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0f);
                //sb.Draw(Assets.tex_obj_platform1, _position, Color.White);
                //DrawMovingObject(curve_curpos, sb);
                if (_health != _maxHealth)
                    DrawHealth(sb);
            }
        }
        public void Kill()
        {
            if (!_isHit)
            {
                _isHit = true;
                if (Main.gsm.gameScene.EnemiesAlive == 1 && Main.gsm.gameScene._monsterManager.CurrentWave.nrOfmonstInCurrentWave <= 0)
                {
                    Main.gsm.gameScene.NextWave();
                    Main.gsm.gameScene._monsterManager.enemies.Remove(this);
                }
                Main.gsm.gameScene.EnemiesAlive--;
                Main.gsm.gameScene.Money += reward;
            }
        }
        public void DamagePlayer()
        {
            if (!_isHit)
            {
                if (Main.gsm.gameScene.EnemiesAlive == 1 && Main.gsm.gameScene._monsterManager.CurrentWave.nrOfmonstInCurrentWave <= 0)
                {
                    Main.gsm.gameScene.NextWave();
                    Main.gsm.gameScene._monsterManager.enemies.Remove(this);
                }
                Main.gsm.gameScene.EnemiesAlive--;
                _isHit = true;
                Main.gsm.gameScene.Health--;
            }
        }
        public void DrawHealth(SpriteBatch sb)
        {
            var maxSize = new Point(70, 2);

            var color = new Color();
            color.R = (byte)MathHelper.Min((510 * (_maxHealth - _health)) / 100, 255);
            color.G = (byte)255;

            var size = (float)maxSize.X * ((float)_health / (float)_maxHealth);
            var position = _position.ToPoint() - new Point(0, 10);

            sb.Draw(Assets.texHP, new Rectangle(position - new Point(1, 1), maxSize + new Point(2, 2)), Color.Black);
            sb.Draw(Assets.texHP, new Rectangle(position, new Point((int)size, maxSize.Y)), color);

        }

        private void CalculateFrames(int frameCount, int speed)
        {
            if (_texture == null)
                return;

            // Calculate the width and height of each frame
            frameWidth = _texture.Width / frameCount;
            frameHeight = _texture.Height;

            // Calculate the number of frames horizontally and vertically
            columns = frameCount;

            // Calculate the total number of frames
            totalFrames = columns;

            // Calculate the frame index based on time and speed
            timePerFrame = 1f / speed;
        }

        private void CalculateFrames(GameTime gameTime)
        {
            if (_texture == null || totalFrames == 0)
                return;

            int frameIndex = (int)(gameTime.TotalGameTime.TotalSeconds / timePerFrame) % totalFrames;

            // Calculate the source rectangle for the current frame
            source = new Rectangle(frameIndex * frameWidth, 0, frameWidth, frameHeight);
        }
    }
}

