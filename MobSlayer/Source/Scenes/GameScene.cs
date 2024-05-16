using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MobSlayer;
using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class GameScene
    {
        LevelManager levelManager;
        MonsterManager monsterManager;

        public GameScene()
        {
            Create();
        }
        public void Create()
        {
            levelManager = new();
            levelManager.CreateLevel(Main.graphics.GraphicsDevice);
            monsterManager = new(Main.graphics.GraphicsDevice);
        }
        public void Update(GameTime gt)
        {
            monsterManager.Update(gt);
            if (KeysStates.KeyPressed(Keys.Escape))
                Main.gsm.ChangeLevel(GameStateManager.GameState.Game);
        }
        public void Draw(SpriteBatch sb)
        {
            levelManager.Draw(sb, 0);
            monsterManager.Draw(sb);

        }
    }
}