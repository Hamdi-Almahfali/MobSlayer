using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MobSlayer
{
    internal abstract class GameObject
    {
        protected Vector2 _position;
        protected Texture2D _texture;

        public Vector2 Position { get { return _position; } set {  _position = value; } }
        public Texture2D texture { get { return _texture; } set { _texture = value; } }


        public GameObject(Vector2 position, Texture2D texture)
        {
            _position = position;
            _texture = texture;
        }
    }
}
