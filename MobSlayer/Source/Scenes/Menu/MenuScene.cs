using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobSlayer.Source.Scenes.Menu
{
    public class MenuScene
    {
        List<Button> menuButtons;
        Button btn_play;
        Button btn_settings;
        Button btn_exit;


        public MenuScene()
        {
            
        }
        public void Create(ContentManager content)
        {
            menuButtons = new List<Button>();
            btn_play = new("Play", new Vector2(Data.screenW / 2, Data.tileSize * 15), StartGame);
            btn_settings = new("Settings", new Vector2(Data.screenW / 2, Data.tileSize * 18), Settings);
            btn_exit = new("exit", new Vector2(Data.screenW / 2, Data.tileSize * 21), CloseGame);
            menuButtons.Add(btn_play);
            menuButtons.Add(btn_settings);
            menuButtons.Add(btn_exit);

            foreach (var button in menuButtons)
            {
                button.Create(content);
            }
        }
        public void Update(GameTime gt)
        {
            btn_play.Update(gt);
            btn_settings.Update(gt);
            btn_exit.Update(gt);
        }
        public void Draw(SpriteBatch sb)
        {
            // Draw Menu Background
            var bg = Assets.tex_menu_bg;
            sb.Draw(bg, new Vector2(Data.screenW / 2 - bg.Width / 2, 0), Color.White);
            // Draw menu title
            var title = Assets.tex_menu_title;
            sb.Draw(title, new Vector2(Data.screenW / 2 - title.Width / 2, Data.tileSize * 4), Color.White);
            // Draw Menu Art
            var art = Assets.tex_menu_art;
            sb.Draw(art, new Vector2(Data.screenW / 2 - art.Width / 2, Data.tileSize * 10), Color.White);

            // Draw the buttons
            btn_play.Draw(sb);
            btn_settings.Draw(sb);
            btn_exit.Draw(sb);
        }
        private void StartGame()
        {
            Main.gsm.ChangeLevel(GameStateManager.GameState.Game);
        }
        private void Settings()
        {

        }
        private void CloseGame()
        {
            Application.Exit();
        }
    }
}
