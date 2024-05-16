using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MobSlayer
{
    public class Main : Game
    {
        internal static GameStateManager gsm;

        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // SET SCREEN SIZE
            Data.SetScreenSize(graphics);

            gsm = new();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Assets.LoadTextures(Content);

        }

        protected override void Update(GameTime gameTime)
        {
            // Update State Manager
            gsm.Update(gameTime);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            string hexColorCode = "#1b0d35";
            Color color = Data.HexToColor(hexColorCode);

            GraphicsDevice.Clear(color);
            

            gsm.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}