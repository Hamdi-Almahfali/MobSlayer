using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class ShowWaveTitle
    {
        private CustomTimer _timer;
        private Texture2D _texture;

        public ShowWaveTitle(GameScene.GameState state)
        {
            _timer = new CustomTimer();
        }

        public void Update(GameTime gt)
        {
            _timer.Update(gt);
        }
    }
}
