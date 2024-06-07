using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class StrongBat : Enemy
    {
        public StrongBat(int reward, float moveSpeed, Vector2 position = default, Texture2D texture = default, int size = default, int speed = default)
           : base(reward, moveSpeed, position, texture, size, speed)
        {
            _texture = Assets.tex_enemy_batS;
        }
    }
}
