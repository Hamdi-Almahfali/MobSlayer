using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MobSlayer.Source.Scenes.Menu
{
    internal class MenuScene
    {
        Button btn_play;
        Button btn_settings;
        Button btn_credits;

        public MenuScene()
        {
            btn_play = new("Play", Assets.fnt_pixel, new Vector2(Data.screenW / 2, Data.tileSize * 5));
            //btn_settings = new();
            //btn_credits = new();
        }
        public void Create()
        {

        }
        public void Update(GameTime gt)
        {
            btn_play.Update(gt);
        }
        public void Draw(SpriteBatch sb)
        {
            // Draw Menu Background
            var bg = Assets.tex_menu_bg;
            sb.Draw(bg, new Vector2(0, 0), Color.White);
            // Draw menu title
            var title = Assets.tex_menu_title;
            sb.Draw(title, new Vector2(Data.screenW / 2 - title.Width / 2, Data.tileSize * 4), Color.White);
            // Draw Menu Art
            var art = Assets.tex_menu_art;
            sb.Draw(art, new Vector2(0, Data.tileSize * 10), Color.White);

            btn_play.Draw(sb);
        }
    }
}
