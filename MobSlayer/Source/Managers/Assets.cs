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
            // UI
                // Menu
                public static Texture2D tex_menu_title;
                public static Texture2D tex_menu_art;
                public static Texture2D tex_menu_bg;
                // In-Game
                public static Texture2D tex_game_wave1;
                public static Texture2D tex_game_wave2;
                public static Texture2D tex_game_wave3;

            // Objects
        public static Texture2D tex_enemy_batS;

            // Environment
        public static Texture2D tex_env_grass0;
        public static Texture2D tex_env_sand0;



        // Transparent bg
        public static Texture2D tsb;

        public static SpriteFont fnt_pixel;

        public static void LoadTextures(ContentManager content)
        {
            tex_menu_title = content.Load<Texture2D>(@"assets\UI\game_title");
            tex_menu_art = content.Load<Texture2D>(@"assets\UI\menu_art");
            tex_menu_bg = content.Load<Texture2D>(@"assets\UI\menu_bg");
            tex_game_wave1 = content.Load<Texture2D>(@"assets\UI\wave1");
            tex_game_wave2 = content.Load<Texture2D>(@"assets\UI\wave2");
            tex_game_wave3 = content.Load<Texture2D>(@"assets\UI\wave3");

            tex_enemy_batS = content.Load<Texture2D>(@"assets\Entities\bat_strong");

            tex_env_grass0 = content.Load<Texture2D>(@"assets\Seamless\grass0");
            tex_env_sand0 = content.Load<Texture2D>(@"assets\Seamless\sand0");

            tsb = content.Load<Texture2D>(@"transparentSquareBackground");

            fnt_pixel = content.Load<SpriteFont>("Pixeboy");
        }
    }
}
