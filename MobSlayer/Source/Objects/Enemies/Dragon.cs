﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    internal class Dragon : Enemy
    {
        public Dragon(int reward, float moveSpeed, Vector2 position, Texture2D texture, int frameCount, int speed) : base(reward, moveSpeed, position, texture, frameCount, speed)
        {
            _isBoss = true;
            original_curve_speed = moveSpeed / 1.7f;
            curve_speed = original_curve_speed;
            _maxHealth = _maxHealth * 30;
            _health = _maxHealth;
        }
    }
}