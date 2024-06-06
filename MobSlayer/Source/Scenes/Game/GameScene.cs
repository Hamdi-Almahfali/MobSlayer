using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Source;
using Spline;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    public class GameScene
    {
        public GameState CurrentGameState { get => _gameState; }
        public enum GameState
        {
            Intro,
            Wave1,
            Wave2,
            Wave3,
            Outro
        }
        private GameState _gameState;

        public GameScene()
        {
            Create();
        }
        public void Create()
        {
            


        }
        public void Update(GameTime gt)
        {
            batPos += (int)(gt.ElapsedGameTime.TotalSeconds * 200);
            bat.Update(gt);

            // DEBUG
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Main.gsm.ChangeLevel(GameStateManager.GameState.Game);
            }
        }
        public void Draw(SpriteBatch sb)
        {
            path.Draw(sb);
            if (batPos < path.endT)
                bat.Position = path.GetPos(batPos);
            bat.Draw(sb);
            path.DrawPoints(sb);

        }
    }
}