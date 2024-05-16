using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class Assets
    {
        public static Texture2D tex_menu_title;
        public static Texture2D tex_menu_art;
        public static Texture2D tex_menu_bg;

        public static SpriteFont fnt_pixel;

        public static void LoadTextures(ContentManager content)
        {
            tex_menu_title = content.Load<Texture2D>(@"assets\UI\game_title");
            tex_menu_art = content.Load<Texture2D>(@"assets\UI\menu_art");
            tex_menu_bg = content.Load<Texture2D>(@"assets\UI\menu_bg");

            fnt_pixel = content.Load<SpriteFont>(@"pixeFont");
        }
    }
}
