using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MobSlayer
{
    internal class Tower : GameObject
    {
        public Tower(Vector2 position, Texture2D texture) : base(position, texture)
        {
        }
    }
}
