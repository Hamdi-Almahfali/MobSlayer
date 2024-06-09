using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MobSlayer
{
    public class Tower : GameObject
    {
        private Item.ItemType type;
        private Texture2D turretTexture;
        private float rotation;
        // Turret properties
        private float shootSpeed = 1f;
        private int damage = 3;
        private float? aoeRadius;
        private float? slowDuration;
        private int range;
        private int price;
        private CustomTimer shootCooldown;
        private Vector2 turretPosition;

        private Vector2 targetPosition;
        Color circleColor = Color.White; // Color of the circle

        private bool isSelected = false;
        public bool IsSold;

        public Tower(Vector2 position, Item.ItemType type, int price) : base(position)
        {
            this.price = price;
            this.Position = position;
            this.type = type;
            IsSold = false;

            GetTurretType();

            targetPosition = new Vector2(-50, 250);
            var origin = new Vector2(turretTexture.Width / 2, turretTexture.Height / 2);
            turretPosition = new Vector2((int)Position.X, (int)Position.Y - turretTexture.Height / 2) + origin;
            texture = Assets.tex_obj_platform1;

            shootCooldown = new CustomTimer();
        }

        public void Update(GameTime gt)
        {
            DisplayRange();
            shootCooldown.Update(gt); // Update turret cooldown

            float bestDist = float.MaxValue;
            Enemy bestEnemy = null;
            float radiusSquared = range * range; // Calculating squared radius for efficiency
            foreach (var enemy in Main.gsm.gameScene._monsterManager.enemies)
            {
                float distanceSquared = Vector2.DistanceSquared(enemy.Position, _position);
                if (!(distanceSquared <= radiusSquared) || enemy.IsHit)
                    continue;

                if (bestDist > Vector2.Distance(enemy.Position, _position))
                {
                    bestEnemy = enemy;
                    bestDist = Vector2.Distance(enemy.Position, _position);

                }
            }

            if (bestEnemy != null)
            {
                targetPosition = bestEnemy.Position;
                if (shootCooldown.IsDone())
                {
                    if (aoeRadius == null)
                        Shoot(bestEnemy);
                    else
                        AOEShoot(bestEnemy);
                }
            }
            CheckIfSold();
        }
        public void Draw(SpriteBatch sb)
        {
            // Draw platform
            sb.Draw(texture, Position, Color.White);

            // Draw the turret
            // Get origin of the turret
            var origin = new Vector2(turretTexture.Width / 2, turretTexture.Height / 2);
            // Get the vector direction to look at
            Vector2 direction = targetPosition - Position;
            // Set the rotation using Math.Atan2 with the direction
            rotation = MathHelper.Lerp(rotation, (float)Math.Atan2(direction.Y, -direction.X), 0.2f);

            turretPosition.X = MathHelper.Lerp(turretPosition.X, Position.X + origin.X, 0.2f);
            turretPosition.Y = MathHelper.Lerp(turretPosition.Y, Position.Y - turretTexture.Height / 2 + origin.Y, 0.2f);
            sb.Draw(turretTexture, turretPosition, null, Color.White, -rotation, origin, 1.0f, SpriteEffects.None, 0f);
            if (KeysStates.GetMouseRect().Intersects(hitbox) || isSelected)
                DrawRangeCircle(sb, turretPosition);


        }
        public void Shoot(Enemy enemy)
        {
            // Calculate direction vector from turret to enemy
            Vector2 direction = enemy.Position - turretPosition;

            // Normalize the direction vector to maintain direction but with a length of 1
            direction.Normalize();

            // Apply recoil in the opposite direction of the normalized direction vector
            turretPosition -= direction * 10;



            // Deal damage
            enemy.Health -= damage;
            enemy.hurtCooldown.ResetAndStart(1);

            // Apply frost
            if (slowDuration != null)
            {
                enemy.Slowdown((float)slowDuration);
                Main.gsm.gameScene.ParticleEmitters.Add(new ParticleEmitter(true, Assets.tex_env_frost, 15, enemy.Position, 0.8f));
            }

            // Start shoot cooldown
            shootCooldown.ResetAndStart(shootSpeed);
        }
        public void AOEShoot(Enemy enemy)
        {
            // Calculate direction vector from turret to enemy
            Vector2 direction = enemy.Position - turretPosition;

            // Normalize the direction vector to maintain direction but with a length of 1
            direction.Normalize();

            // Apply recoil in the opposite direction of the normalized direction vector
            turretPosition -= direction * 10;

            // Deal damage
            enemy.Health -= damage;
            enemy.hurtCooldown.ResetAndStart(1);

            var targetsInProximity = Main.gsm.gameScene.GetTargetsWithinRadius(enemy.Position, (float)aoeRadius);
            foreach (var target in targetsInProximity)
            {
                var dist = Vector2.Distance(target.Position, _position);

                var _damage = damage * Math.Exp(-dist / (float)aoeRadius);

                target.Health -= ((int)_damage);

            }
            var smoke = Assets.tex_env_smoke;
            var position = new Vector2(enemy.Position.X - smoke.Width / 2, enemy.Position.Y - smoke.Height / 2);
            Main.gsm.gameScene.ParticleEmitters.Add(new ParticleEmitter(false, smoke, 15, position));
            // Start shoot cooldown
            shootCooldown.ResetAndStart(shootSpeed);
        }
        private void CheckIfSold()
        {
            if (IsSold)
                return;
            // Backspace is pressed
            if (KeysStates.KeyPressed(Keys.Back))
            {
                // Check if Selected
                if (isSelected)
                {
                    // Sell tower
                    Main.gsm.gameScene.Money += (int)(price / 1.5f);
                    IsSold = true;
                    // Add sold money particles
                    var dollar = Assets.tex_env_dollar;
                    Main.gsm.gameScene.ParticleEmitters.Add(new ParticleEmitter(false, dollar, 2, new Vector2(Position.X + dollar.Width / 2, Position.Y), 0.5f, Color.Red));
                }
            }
        }
        private void DisplayRange()
        {
            if (KeysStates.RightClick())
            {
                isSelected = false;
                if (KeysStates.GetMouseRect().Intersects(hitbox))
                {
                    isSelected = true;
                }
            }
            if (KeysStates.LeftClick() &&
                !KeysStates.GetMouseRect().Intersects(hitbox) &&
                 KeysStates.GetMouseRect().Intersects(new Rectangle(0, 0, Data.screenW, 700)))
            {
                isSelected = false;
            }
            if (isSelected)
            {
                circleColor = Color.Yellow;
            }
            else
            {
                circleColor = Color.White;
            }
        }
        private void DrawRangeCircle(SpriteBatch sb, Vector2 turretPosition)
        {
            int segments = 50; // Number of line segments to approximate the circle

            // Draw the circle
            for (int i = 0; i < segments; i++)
            {
                float angle1 = i * MathHelper.TwoPi / segments;
                float angle2 = (i + 1) * MathHelper.TwoPi / segments;

                Vector2 pos1 = new Vector2((float)Math.Cos(angle1) * range + turretPosition.X,
                                            (float)Math.Sin(angle1) * range + turretPosition.Y);
                Vector2 pos2 = new Vector2((float)Math.Cos(angle2) * range + turretPosition.X,
                                            (float)Math.Sin(angle2) * range + turretPosition.Y);

                sb.Draw(Main.Pixel, pos1, null, circleColor, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
                sb.Draw(Main.Pixel, pos2, null, circleColor, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

                sb.DrawLine(pos1, pos2, circleColor);
            }
        }
        private void GetTurretType()
        {
            switch (type)
            {
                case Item.ItemType.Basic:
                    turretTexture = Assets.tex_obj_turret1;
                    range = Main.gsm.BN.ShooterRange;
                    damage = Main.gsm.BN.ShooterDamage;
                    shootSpeed = Main.gsm.BN.ShooterShotSpeed;
                    break;
                case Item.ItemType.Cannon:
                    turretTexture = Assets.tex_obj_turret3;
                    range = Main.gsm.BN.CannonRange;
                    damage = Main.gsm.BN.CannonDamage;
                    shootSpeed = Main.gsm.BN.CannonShotSpeed;
                    aoeRadius = Main.gsm.BN.CannonAoe;
                    break;
                case Item.ItemType.Icy:
                    turretTexture = Assets.tex_obj_turret2;
                    range = Main.gsm.BN.FrostRange;
                    shootSpeed = Main.gsm.BN.FrostShotSpeed;
                    damage = Main.gsm.BN.FrostDamage;
                    slowDuration = Main.gsm.BN.FrostSlowDuration;
                    break;
                default:
                    break;
            }
        }
    }
}
