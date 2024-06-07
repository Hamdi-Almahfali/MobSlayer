using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    /// <summary>
    /// The item that floats in the air to be placed down
    /// </summary>
    public class TowerItem
    {
        private Texture2D _texture;
        private Vector2 _position;
        private Color _color = new Color(255, 255, 255, 128);
        private Item.ItemType Type;
        private Texture2D _icon;
        private GuiShop _shop;
        private int _price;

        public TowerItem(Item.ItemType itemType, Texture2D icon, int price, GuiShop shop)
        {
            Type = itemType;
            _icon = icon;
            _shop = shop;
            _price = price;
            ChangeTexture();
        }
        public void Update(GameTime gameTime)
        {
            _position = KeysStates.mouseState.Position.ToVector2();
            CheckClick();
        }
        public void Draw(SpriteBatch sb)
        {
            sb.Draw(_texture, _position, _color);
            sb.Draw(_icon, new Vector2(_position.X, _position.Y - _icon.Height / 2), _color);
        }
        public void CheckClick()
        {
            // Cancels placing tower with right click
            if (KeysStates.RightClick())
            {
                _shop.gs.Money += _price;
                _shop.towerItem = null;
                _shop.ItemInHand = false;
                return;
            }
            // Place tower
            if (KeysStates.LeftClick())
            {
                _shop.gs.PlaceTower(Type, _position);
            }
        }
        public void ChangeTexture()
        {
            switch (Type)
            {
                case Item.ItemType.Basic:
                    _texture = Assets.tex_obj_platform1;
                    break;
                case Item.ItemType.Cannon:
                    _texture = Assets.tex_obj_platform1;
                    break;
                case Item.ItemType.Icy:
                    _texture = Assets.tex_obj_platform1;
                    break;

            }
        }
    }
}
