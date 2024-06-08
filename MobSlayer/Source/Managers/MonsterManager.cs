using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MobSlayer
{
    public class MonsterManager
    {
        public List<Enemy> enemies;
        public int timeSinceLastMonst = 0;
        public Wave CurrentWave {  get => _currentWave; set => _currentWave = value; }
        GraphicsDevice gd;
        Wave _currentWave;

        public MonsterManager(GraphicsDevice gd, Wave currentWave)
        {
            this.gd = gd;
            _currentWave = currentWave;
            enemies = new List<Enemy>();
        }
        public void LoadWave(GameTime gt)
        {
            timeSinceLastMonst += gt.ElapsedGameTime.Milliseconds;
            if (_currentWave.nrOfmonstInCurrentWave > 0 && timeSinceLastMonst > _currentWave.mBetweenCreation)
            {
                timeSinceLastMonst -= _currentWave.mBetweenCreation;
                StrongBat c = new(Main.gsm.BN.BatKillReward, Main.gsm.BN.Wave1BatSpeed,Main.gsm.gameScene._level.cpath_road.EvaluateAt(0), Assets.tex_enemy_batS, 5, 10);
                enemies.Add(c);
                --_currentWave.nrOfmonstInCurrentWave;
                Main.gsm.gameScene.EnemiesAlive++;
            }
        }

        public void Update(GameTime gt)
        {
            LoadWave(gt);
            foreach (Enemy c in enemies)
            {
                c.Update(gt);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Enemy c in enemies)
            {
                if (!c.IsHit)
                    c.Draw(spriteBatch);
            }

        }
        public void ChangeWave(Wave wave)
        {
            _currentWave = wave;
            timeSinceLastMonst = 0;
        }
    }
}
