using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MobSlayer
{
    public abstract class GameObject
    {
        protected Vector2 _position;
        protected Texture2D _texture;
        protected Rectangle _hitbox;

        public Vector2 Position { get { return _position; } set {  _position = value; } }
        public Texture2D texture { get { return _texture; } set { _texture = value; } }
        public Rectangle hitbox { get { return _hitbox; } set { _hitbox = value; } }


        public GameObject(Vector2 position, Texture2D texture)
        {
            _position = position;
            _texture = texture;

            if (_texture == null)
                return;
            _hitbox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

        protected GameObject(Vector2 position)
        {
            Position = position;
            texture = Assets.tex_obj_platform1;
            _hitbox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

    }
}
