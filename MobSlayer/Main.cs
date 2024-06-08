using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using WinForm;

namespace MobSlayer
{
    public class Main : Game
    {
        public static GameStateManager gsm;

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
            Window.AllowAltF4 = false;
            Window.Title = "Dragon Hunter";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Assets.LoadTextures(Content);
            gsm = new(Content, this);
            // Inside LoadContent method
            // Inside LoadContent method
            Pixel = new Texture2D(GraphicsDevice, 1, 1);
            Pixel.SetData(new[] { Color.White
    });
        }

        protected override void Update(GameTime gameTime)
        {
            // Update State Manager
            gsm.Update(gameTime);
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                gsm.ChangeLevel(GameStateManager.GameState.Menu);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.Black);
            

            gsm.Draw(spriteBatch);

            base.Draw(gameTime);
        }
        public static Texture2D Pixel { get; private set; }


    }


}