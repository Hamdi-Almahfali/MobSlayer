using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Source
{
    internal class GameStateManager
    {
        // Declaring scenes
        MenuScene menuScene;
        GameScene gameScene;

        // Game states
        public enum GameState
        {
            Menu,
            Settings,
            Game,
            Win,
            Lose
        }
        private GameState _state;
        public GameState State
        {
            get => _state;
            set => _state = value;
        }
        public GameStateManager()
        {
            Create();
        }
        public void Create()
        {
            ChangeLevel(GameState.Game);
        }
        public void Update(GameTime gt)
        {
            KeysStates.Update();

            switch (_state)
            {
                case GameState.Menu:
                    break;
                case GameState.Settings:
                    break;
                case GameState.Game:
                    gameScene.Update(gt);
                    break;
                case GameState.Win:
                    break;
                case GameState.Lose:
                    break;
            }
        }
        public void Draw(SpriteBatch sb)
        {
            switch (_state)
            {
                case GameState.Menu:
                    break;
                case GameState.Settings:
                    break;
                case GameState.Game:
                    sb.Begin();
                    gameScene.Draw(sb);
                    sb.End();
                    break;
                case GameState.Win:
                    break;
                case GameState.Lose:
                    break;
            }
        }
        public void ChangeLevel(GameState level)
        {
            switch (level)
            {
                case GameState.Menu:

                    break;
                case GameState.Settings:
                    break;
                case GameState.Game:
                    gameScene = new();
                    State = level;
                    break;
                case GameState.Win:
                    break;
                case GameState.Lose:
                    break;
            }
        }
    }
}
