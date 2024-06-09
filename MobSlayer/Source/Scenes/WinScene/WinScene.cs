using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MobSlayer
{
    public class WinScene
    {
        private Texture2D _titleTexture;
        private Vector2 _titlePosition;

        private Button _restartButton;

        public WinScene()
        {
            _titleTexture = Assets.tex_game_win;
            var textSize = Assets.fnt_pixel.MeasureString("Restart Game");
            _titlePosition = new Vector2(Data.screenW / 2 - _titleTexture.Width / 2, Data.tileSize * 3);
            _restartButton = new Button("Restart Game", new Vector2(Data.screenW / 2, Data.screenH / 2 + Data.tileSize * 7), RestartGame);
        }
        public void Create(ContentManager content)
        {
            _restartButton.Create(content);
        }
        public void Update(GameTime gt)
        {
            _restartButton.Update(gt);
        }
        public void Draw(SpriteBatch sb)
        {
            sb.Begin();
            sb.Draw(_titleTexture, _titlePosition, Color.White);
            _restartButton.Draw(sb);
            sb.End();
        }
        public void RestartGame()
        {
            Main.gsm.ChangeLevel(GameStateManager.GameState.Game);
        }
    }
}
