using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MobSlayer
{
    public class GuiShop
    {
        public Vector2 Position { get => position; set => position = value; }
        public bool ItemInHand { get => _itemInHand; set => _itemInHand = value; }
        public TowerItem towerItem;

        private Vector2 position;

        private float percentage = 1;
        private List<Item> items;
        private bool _itemInHand = false;

        public GameScene gs;
        public GuiShop(GameScene gs)
        {
            this.gs = gs;
            items = new List<Item>();
            int boxWidth = 116;
            int gap = 4;

            position = new Vector2(Data.screenW, 700);

            // Adjusting the initial position
            Vector2 initialPosition = new Vector2(355, 715);

            for (int i = 0; i < 3; i++)
            {
                // Calculate the position of each box
                Vector2 position = new Vector2(initialPosition.X + i * (boxWidth + gap), initialPosition.Y);
                Item item = new Item(position, (Item.ItemType) i, this);
                items.Add(item);
            }
        }
        public void Update(GameTime gt)
        {
            foreach (var item in items)
            {
                item.Update(gt);
            }
            if (towerItem != null)
            {
                towerItem.Update(gt);
            }
        }
        public void Draw(SpriteBatch sb)
        {
            DrawRectangles(sb);
            DrawMoney(sb);
            DrawHealth(sb);

            foreach (var item in items)
            {
                item.Draw(sb);
            }
            if (towerItem != null)
            {
                towerItem.Draw(sb);
            }
        }
        public void BuyTower(Item.ItemType itemType, int price, Texture2D icon)
        {
            towerItem = new TowerItem(itemType, icon, price, this);
            gs.Money -= price;
        }

        public void DrawRectangles(SpriteBatch sb)
        {
            sb.DrawRectangle(new Rectangle(0, 700, Data.screenW, 15), Data.HexToColor("3f3f74"));
            sb.DrawRectangle(new Rectangle(0, 710, Data.screenW, 200), Data.HexToColor("68689c"));
            sb.DrawRectangle(new Rectangle(0, 710, 350, 200), Data.HexToColor("222034"));
        }
        public void DrawMoney(SpriteBatch sb)
        {
            sb.DrawString(Assets.fnt_pixel, $"MONEY: ${gs.Money}", new Vector2(0,732), Assets.yellow);
        }
        public void DrawHealth(SpriteBatch sb)
        {
            var healthBarLength = 330;
            var outlineThickness = 4;
            sb.DrawRectangle(new Rectangle(8, 839, healthBarLength + outlineThickness, 48 + outlineThickness), Color.White); // Outline rectangle
            sb.DrawRectangle(new Rectangle(10, 841, healthBarLength, 48), Data.HexToColor("300808")); // Background of healthbar

            // Healthbar 0-10
            percentage = MathHelper.Lerp(percentage,(gs.Health / 10.0f),0.1f);
            int healthBarWidth = (int)(healthBarLength * percentage);

            // Draw the health bar
            sb.DrawRectangle(new Rectangle(10, 841, healthBarWidth, 48), Data.HexToColor("ac3232"));

            sb.Draw(Assets.tex_game_health, new Vector2(78, 819), Color.White);

        }
    }
}
