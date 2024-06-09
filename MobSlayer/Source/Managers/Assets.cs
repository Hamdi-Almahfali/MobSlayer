using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MobSlayer
{
    /// <summary>
    /// Class for loading all game's textures
    /// </summary>
    internal class Assets
    {
        // Game palette main colors
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
        public static Texture2D tex_game_health;
        public static Texture2D tex_game_loss;
        public static Texture2D tex_game_win;

        // Objects
        public static Texture2D tex_enemy_batS;
        public static Texture2D tex_enemy_batW;
        public static Texture2D tex_enemy_dragon;
        public static Texture2D tex_obj_platform1;
        public static Texture2D tex_obj_platform2;
        public static Texture2D tex_obj_platform3;
        public static Texture2D tex_obj_turret1;
        public static Texture2D tex_obj_turret2;
        public static Texture2D tex_obj_turret3;

        // Environment
        public static Texture2D tex_env_grass0;
        public static Texture2D tex_env_sand0;
        public static Texture2D tex_env_smoke;
        public static Texture2D tex_env_frost;
        public static Texture2D tex_env_dollar;



        // Transparent bg
        public static Texture2D tsb;

        public static SpriteFont fnt_pixel;
        public static SpriteFont fnt_pixelSmall;
        public static SpriteFont fnt_default;

        public static Texture2D texHP = null;

        public static void LoadTextures(ContentManager content)
        {
            tex_menu_title = content.Load<Texture2D>(@"assets\UI\game_title");
            tex_menu_art = content.Load<Texture2D>(@"assets\UI\menu_art");
            tex_menu_bg = content.Load<Texture2D>(@"assets\UI\menu_bg");
            tex_game_wave1 = content.Load<Texture2D>(@"assets\UI\wave1");
            tex_game_wave2 = content.Load<Texture2D>(@"assets\UI\wave2");
            tex_game_wave3 = content.Load<Texture2D>(@"assets\UI\wave3");
            tex_game_health = content.Load<Texture2D>(@"assets\UI\health");
            tex_game_loss = content.Load<Texture2D>(@"assets\UI\youDied");
            tex_game_win = content.Load<Texture2D>(@"assets\UI\youWon");

            tex_enemy_batS = content.Load<Texture2D>(@"assets\Entities\bat_strong");
            tex_enemy_batW = content.Load<Texture2D>(@"assets\Entities\bat_weak");
            tex_enemy_dragon = content.Load<Texture2D>(@"assets\Entities\dragon");
            tex_obj_platform1 = content.Load<Texture2D>(@"assets\Objects\platform1");
            tex_obj_platform2 = content.Load<Texture2D>(@"assets\Objects\platform2");
            tex_obj_platform3 = content.Load<Texture2D>(@"assets\Objects\platform3");
            tex_obj_turret1 = content.Load<Texture2D>(@"assets\Entities\turret1");
            tex_obj_turret2 = content.Load<Texture2D>(@"assets\Entities\turret2");
            tex_obj_turret3 = content.Load<Texture2D>(@"assets\Entities\turret3");

            tex_env_grass0 = content.Load<Texture2D>(@"assets\Seamless\grass0");
            tex_env_sand0 = content.Load<Texture2D>(@"assets\Seamless\sand0");
            tex_env_smoke = content.Load<Texture2D>(@"assets\Entities\smoke");
            tex_env_frost = content.Load<Texture2D>(@"assets\Entities\frost");
            tex_env_dollar = content.Load<Texture2D>(@"assets\Entities\dollar");

            tsb = content.Load<Texture2D>(@"transparentSquareBackground");

            fnt_pixel = content.Load<SpriteFont>("Pixeboy");
            fnt_pixelSmall = content.Load<SpriteFont>("PixeboySmall");
            fnt_default = content.Load<SpriteFont>("arial");

            texHP = new Texture2D(Main.graphics.GraphicsDevice, 1, 1);
            texHP.SetData(new[] { Color.White });
        }

    }
}
