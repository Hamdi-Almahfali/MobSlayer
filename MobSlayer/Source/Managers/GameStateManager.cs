using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MobSlayer.Source.Scenes.Menu;
using WinForm;

namespace MobSlayer
{
    /// <summary>
    /// The game's state manager
    /// Game controller
    /// </summary>
    public class GameStateManager
    {
        // Declaring scenes
        public MenuScene menuScene;
        public GameScene gameScene;
        public LossScene lossScene;
        public WinScene winScene;

        public GameTime gameTime;

        public bool IsPaused { get => _isPaused; set => _isPaused = value; }

        public BN BN;
        Main main;

        bool _isPaused = false;
        public Form1 Form; // Windows forms


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
        public GameStateManager(ContentManager content, Main main)
        {
            gameTime = new GameTime();
            this.content = content;
            BN = new BN();

            Create();
            this.main = main;
        }
        public void Create()
        {
            ChangeLevel(GameState.Menu);
            Form = new Form1(main);
        }
        public void Update(GameTime gt)
        {
            gameTime = gt;
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
                    if (!Form.Pause)
                        gameScene.Update(gt);
                    GameControls();
                    break;
                case GameState.Win:
                    winScene.Update(gt);
                    break;
                case GameState.Lose:
                    lossScene.Update(gt);
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
                    winScene.Draw(sb);
                    break;
                case GameState.Lose:
                    lossScene.Draw(sb);
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
                    winScene = new();
                    winScene.Create(content);
                    State = level;
                    break;
                case GameState.Lose:
                    lossScene = new();
                    lossScene.Create(content);
                    State = level;
                    break;
            }
        }
        private void GameControls()
        {
            if (KeysStates.KeyPressed(Keys.P))
            {
                if (Form.IsDisposed)
                    Form = new Form1(main);
                Form.Show();
                Form.Text = "Cheats Panel";
            }
        }
    }
}
