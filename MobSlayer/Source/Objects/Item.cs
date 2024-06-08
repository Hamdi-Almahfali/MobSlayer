using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    /// <summary>
    /// The GUI item that is clicked to be bought
    /// </summary>
    public class Item
    {
        public enum ItemType
        {
            Basic,
            Cannon,
            Icy
        }
        private GuiShop shop;
        private ItemType itemType;
        private int price;
        private int[] priceArray = {Main.gsm.BN.ShooterPrice, Main.gsm.BN.CannonPrice, Main.gsm.BN.FrostPrice,8,10,10,10};
        private Vector2 pricePosition;
        private string _name;
        private Texture2D _icon;

        MouseState mouseState;
        Rectangle bounds;

        bool drawHighlight = false;

        Color color;


        public Item(Vector2 position, ItemType itemType, GuiShop shop)
        {
            this.shop = shop;
            bounds = new Rectangle((int)position.X, (int)position.Y, 116, 181);
            this.itemType = itemType;
            price = priceArray[(int)itemType];

            // Calculate price position
            var size = Assets.fnt_pixelSmall.MeasureString($"${price}");
            pricePosition = new Vector2(bounds.X + bounds.Width / 2 - size.X / 2, bounds.Y + bounds.Height / 1.5f);

            // Choose name
            SetItemProperties();
            
        }
        public void Update(GameTime gt)
        {
            mouseState = Mouse.GetState();
            Rectangle mouseRect = new Rectangle(mouseState.X, mouseState.Y, 1, 1);


            if (bounds.Intersects(mouseRect))
            {
                drawHighlight = true;
                color = Data.HexToColor("#312f45");
                CheckClick();
            }
            else
            {
                drawHighlight = false;
                color = Data.HexToColor("#222034");
            }
        }
        public void Draw(SpriteBatch sb)
        {
            if (drawHighlight) // Draw backgrounds
            {
                var highlightThickness = 4;
                sb.DrawRectangle(new Rectangle(bounds.X - highlightThickness, bounds.Y - highlightThickness, bounds.Width + highlightThickness * 2, bounds.Height + highlightThickness * 2), Color.White);
            }
            sb.DrawRectangle(bounds, color);

            // Draw price
            sb.DrawString(Assets.fnt_pixelSmall, $"${price}", pricePosition, Color.Wheat);

            // Draw name
            var size = Assets.fnt_default.MeasureString($"{_name}");
            sb.DrawString(Assets.fnt_default, _name, new Vector2(bounds.X + bounds.Width / 2 - size.X / 2, bounds.Y + bounds.Height / 9f), Color.White);

            // Draw icon
            sb.Draw(_icon, new Vector2(bounds.X + bounds.Width / 2 - _icon.Width / 2, bounds.Y + bounds.Height / 3f), Color.White);
        }
        public void CheckClick()
        {
            if (KeysStates.LeftClick())
            {
                if (shop.gs.Money >= price)
                {
                    if (!shop.ItemInHand)
                    {
                        shop.BuyTower(itemType, price, _icon);
                        shop.ItemInHand = true;

                    }
                }
            }
        }
        private void SetItemProperties()
        {
            switch (itemType)
            {
                case ItemType.Basic:
                    _name = "Shooter";
                    _icon = Assets.tex_obj_turret1;
                    break;
                case ItemType.Cannon:
                    _name = "Cannon";
                    _icon = Assets.tex_obj_turret3;
                    break;
                case ItemType.Icy:
                    _name = "Frost";
                    _icon = Assets.tex_obj_turret2;
                    break;
                default:
                    break;
            }
        }
    }
}
