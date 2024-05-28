using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MobSlayer;
using Source;
using Spline;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class GameScene
    {

        SimplePath path;
        StrongBat bat;
        float batPos;

        public GameScene()
        {
            Create();
        }
        public void Create()
        {
            path = new SimplePath(Main.graphics.GraphicsDevice);

            bat = new(Vector2.Zero, Assets.tex_enemy_batS, new Vector2(86, 60), 8);
            batPos = path.beginT;
            path.SetPos(0, Vector2.Zero);
            path.Clean();
            path.AddPoint(new Vector2(0, 300));
            path.AddPoint(new Vector2(400, 300));
            path.AddPoint(new Vector2(401, 300));
            path.AddPoint(new Vector2(500, 500));
            path.AddPoint(new Vector2(501, 500));
            path.AddPoint(new Vector2(Data.screenW, 500));


        }
        public void Update(GameTime gt)
        {
            batPos += (int)(gt.ElapsedGameTime.TotalSeconds * 200);
            bat.Update(gt);

            // DEBUG
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Main.gsm.ChangeLevel(GameStateManager.GameState.Game);
            }
        }
        public void Draw(SpriteBatch sb)
        {
            path.Draw(sb);
            if (batPos < path.endT)
                bat.Position = path.GetPos(batPos);
            bat.Draw(sb);
            path.DrawPoints(sb);

        }
    }
}