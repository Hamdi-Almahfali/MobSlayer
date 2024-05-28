using Microsoft.Xna.Framework;
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
        // Game pallet main colors
        public static Color yellow = Data.HexToColor("e39f4a");
        public static Color blue = Data.HexToColor("563482");

        // Assets
            // Menu
        public static Texture2D tex_menu_title;
        public static Texture2D tex_menu_art;
        public static Texture2D tex_menu_bg;
            // Objects
        public static Texture2D tex_enemy_batS;


        // Transparent bg
        public static Texture2D tsb;

        public static SpriteFont fnt_pixel;

        public static void LoadTextures(ContentManager content)
        {
            tex_menu_title = content.Load<Texture2D>(@"assets\UI\game_title");
            tex_menu_art = content.Load<Texture2D>(@"assets\UI\menu_art");
            tex_menu_bg = content.Load<Texture2D>(@"assets\UI\menu_bg");

            tex_enemy_batS = content.Load<Texture2D>(@"assets\Entities\bat_strong");

            tsb = content.Load<Texture2D>(@"transparentSquareBackground");

            fnt_pixel = content.Load<SpriteFont>("Pixeboy");
        }
    }
}
