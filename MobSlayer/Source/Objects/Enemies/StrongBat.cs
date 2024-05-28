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
        public StrongBat(Vector2 position, Texture2D texture, Vector2 size, int speed) : base(position, texture, size, speed)
        {
        }
    }
}
