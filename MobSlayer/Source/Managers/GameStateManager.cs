using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using MobSlayer.Source.Scenes.Menu;
using Microsoft.Xna.Framework.Content;

namespace MobSlayer
{
    internal class GameStateManager
    {
        // Declaring scenes
        public MenuScene menuScene;
        public GameScene gameScene;

        public BN BN;

        ContentManager content;

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
        public GameStateManager(ContentManager content)
        {
            this.content = content;
            BN = new BN();

            Create();
        }
        public void Create()
        {
            ChangeLevel(GameState.Menu);
        }
        public void Update(GameTime gt)
        {
            switch (_state)
            {
                case GameState.Menu:
                    menuScene.Update(gt);
                    break;
                case GameState.Settings:
                    break;
                case GameState.Game:
                    // Update keys states
                    KeysStates.Update();
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
                    sb.Begin();
                    menuScene.Draw(sb);
                    sb.End();
                    break;
                case GameState.Settings:
                    break;
                case GameState.Game:
                    gameScene.Draw(sb);
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
                    if (gameScene != null)
                        gameScene = null;
                    menuScene = new();
                    menuScene.Create(content);
                    State = level;
                    break;
                case GameState.Settings:
                    break;
                case GameState.Game:
                    BN = new BN();
                    gameScene = new GameScene();
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
