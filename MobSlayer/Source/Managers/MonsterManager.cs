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
                --_currentWave.nrOfmonstInCurrentWave;
                Main.gsm.gameScene.EnemiesAlive++;
                timeSinceLastMonst -= _currentWave.mBetweenCreation;

                if (_currentWave.wave == 3)
                {
                    Dragon c = new(999, _currentWave.enemiesSpeed, Main.gsm.gameScene._level.cpath_road.EvaluateAt(0), Assets.tex_enemy_dragon, 14, 15);
                    enemies.Add(c);
                    return;
                }

                Random random = new Random();
                if (random.Next(5) == 0)
                {
                    WeakBat c = new(Main.gsm.BN.BirdKillReward, _currentWave.enemiesSpeed, Main.gsm.gameScene._level.cpath_road.EvaluateAt(0), Assets.tex_enemy_batW, 1, 1); 
                    enemies.Add(c);
                }
                else
                {
                    StrongBat c = new(Main.gsm.BN.BatKillReward, _currentWave.enemiesSpeed,Main.gsm.gameScene._level.cpath_road.EvaluateAt(0), Assets.tex_enemy_batS, 5, 10);
                    enemies.Add(c);
                }
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
