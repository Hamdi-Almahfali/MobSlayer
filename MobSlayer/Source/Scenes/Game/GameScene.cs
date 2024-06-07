using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spline;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    public class GameScene
    {
        #region Public properties
        public int Money { get => _money; set => _money = value; }
        public int Health { get => _health; }
        public GameState CurrentGameState { get => _gameState; }
        public enum GameState
        {
            Intro,
            Wave1,
            Wave2,
            Wave3,
            Outro
        }
        #endregion

        // Managers
        public Level  _level;
        public MonsterManager _monsterManager;
        private ShowWaveTitle _showWaveTitle;
        private GameState _gameState;
        private List<Tower> _towerList;
        private List<Vector2> controlPoints;
        private Texture2D texture_controlPoints;


        RenderTarget2D _renderTarget; // Level's render target

        private int _money;
        private int _health; // Health goes from 0(dead) to 10(full)
        // Gui shop
        public GuiShop _guiShop;

        public GameScene()
        {
            Create();
        }
        public void Create()
        {
            _level = new Level(Main.graphics.GraphicsDevice);
            _towerList = new List<Tower>();
            _monsterManager = new(Main.graphics.GraphicsDevice);

            _showWaveTitle = new ShowWaveTitle(_gameState);
            _guiShop = new GuiShop(this);

            _money = 507;
            _health = 10;

            _renderTarget = new RenderTarget2D(Main.graphics.GraphicsDevice,
            Main.graphics.GraphicsDevice.Viewport.Width, Main.graphics.GraphicsDevice.Viewport.Height);


            string hexColorCode = "#a6b04f";
            Color color = Data.HexToColor(hexColorCode);
            Main.graphics.GraphicsDevice.Clear(color);

        }
        public void Update(GameTime gt)
        {
            _monsterManager.Update(gt);
            _showWaveTitle.Update(gt);

            _guiShop.Update(gt);
            foreach (Tower tower in _towerList)
            {
                tower.Update(gt);
            }
        }
        public void Draw(SpriteBatch sb)
        {
            //Ändra så att GraphicsDevice ritar mot vårt render target
            Main.graphics.GraphicsDevice.SetRenderTarget(_renderTarget);
            Main.graphics.GraphicsDevice.Clear(Color.Transparent);
            sb.Begin();

            //Rita ut texturen. Den ritas nu ut till vårt render target istället
            _level.Draw(sb);
            foreach (Tower tower in _towerList)
            {
                tower.Draw(sb);
            }
            //för på skärmen.
            sb.End();

            //Sätt GraphicsDevice att åter igen peka på skärmen
            Main.graphics.GraphicsDevice.SetRenderTarget(null);

            string hexColorCode = "#a6b04f";
            Color color = Data.HexToColor(hexColorCode);
            Main.graphics.GraphicsDevice.Clear(color);
            sb.Begin();
            _level.Draw(sb);
            _monsterManager.Draw(sb);
            _showWaveTitle.Draw(sb);

            foreach (Tower tower in _towerList)
            {
                tower.Draw(sb);
            }
            _guiShop.Draw(sb);
            sb.End();

        }
        public void PlaceTower(Item.ItemType type, Vector2 position)
        {
            var tower = new Tower(position, type);
            if (CanPlace(tower))
            {
                _towerList.Add(new Tower(position,type));
                _guiShop.towerItem = null;
                _guiShop.ItemInHand = false;
            }
        }
        private bool CanPlace(GameObject g)
        {
            if (!new Rectangle(0, 0, (int)_guiShop.Position.X, (int)_guiShop.Position.Y).Intersects(new Rectangle(KeysStates.mouseState.X, KeysStates.mouseState.Y, g.texture.Width,g.texture.Height)))
                return false;
            Rectangle adjustedHitbox = g.hitbox;

            if (adjustedHitbox.X < 0 || adjustedHitbox.Y < 0 ||
                adjustedHitbox.Right > _renderTarget.Width || adjustedHitbox.Bottom > _renderTarget.Height)
                return false;

            Color[] pixels = new Color[g.texture.Width * g.texture.Height];
            Color[] pixels2 = new Color[g.texture.Width * g.texture.Height];
            g.texture.GetData<Color>(pixels2);
            _renderTarget.GetData(0, g.hitbox, pixels, 0, pixels.Length);
            for (int i = 0; i < pixels.Length; ++i)
            {
                if (pixels[i].A > 0.0f && pixels2[i].A > 0.0f)
                    return false;
            }
            return true;
        }
    }
}