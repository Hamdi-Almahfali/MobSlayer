using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace MobSlayer
{
    public class ParticleEmitter
    {
        List<Particle> particles;
        float timeLeft;
        int density;
        Texture2D texture;
        Vector2 position;
        bool active = true;
        bool rotate = false;
        Random random;
        Color _color = Color.White;

        public ParticleEmitter(bool rotate, Texture2D texture, int density, Vector2 position, float timeLeft = 0.5f, Color? color = null)
        {
            this.timeLeft = timeLeft;
            this.density = density;
            this.texture = texture;
            this.position = position;
            this.rotate = rotate;

            particles = new List<Particle>();
            random = new Random();
            EmitParticles();

            if (color != null)
                _color = (Color)color;
        }

        private void EmitParticles()
        {
            for (int i = 0; i < density; i++)
            {
                float angle = (float)(random.NextDouble() * Math.PI * 2);
                float speed = (float)(random.NextDouble() * 100 + 50);
                Vector2 velocity = new Vector2((float)Math.Cos(angle) * speed, (float)Math.Sin(angle) * speed);
                particles.Add(new Particle(texture, position, velocity, timeLeft, rotate));
            }
        }

        public void Update(GameTime gameTime)
        {
            if (!active) return;

            for (int i = particles.Count - 1; i >= 0; i--)
            {
                particles[i].Update(gameTime);
                if (!particles[i].IsAlive)
                {
                    particles.RemoveAt(i);
                }
            }

            if (particles.Count == 0)
            {
                active = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!active) return;

            foreach (var particle in particles)
            {
                particle.Draw(spriteBatch, _color);
            }
        }
    }
}