using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class ShowWaveTitle
    {
        private CustomTimer _timer;
        private Texture2D _texture = Assets.tex_game_wave1;

        private Vector2 _position;

        private Vector2 startPosition = new Vector2(Data.screenW / 2 - Assets.tex_game_wave1.Width / 2, -Assets.tex_game_wave1.Height * 2);
        private Vector2 endPosition = new Vector2(Data.screenW / 2 - Assets.tex_game_wave1.Width / 2, Data.tileSize * 3);
        public ShowWaveTitle(GameScene.GameState state)
        {
            _position = startPosition;
            _timer = new CustomTimer();
            _timer.ResetAndStart(2.5f);
            PickWaveImage(state);
        }

        public void Update(GameTime gt)
        {
            _timer.Update(gt);

            if (!_timer.IsDone())
            {
                _position.X = MathHelper.Lerp(_position.X, endPosition.X, 0.07f);
                _position.Y = MathHelper.Lerp(_position.Y, endPosition.Y, 0.07f);
            }
            else
            {
                _position.X = MathHelper.Lerp(_position.X, startPosition.X, 0.1f);
                _position.Y = MathHelper.Lerp(_position.Y, startPosition.Y, 0.1f);
            }
        }
        public void Draw(SpriteBatch sb)
        {
            sb.Draw(_texture, _position, Color.White);
        }
        public void PickWaveImage(GameScene.GameState state)
        {
            switch (state)
            {
                case GameScene.GameState.Wave1:
                    _texture = Assets.tex_game_wave1;
                    break;
                case GameScene.GameState.Wave2:
                    _texture = Assets.tex_game_wave2;
                    break;
                case GameScene.GameState.Wave3:
                    _texture = Assets.tex_game_wave3;
                    break;
                default:
                    _texture = Assets.tex_game_wave3;
                    break;
            }
        }
    }
}
