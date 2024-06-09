using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MobSlayer
{
    /// <summary>
    /// Static data class for global static variables and extention methods
    /// </summary>
    internal static class Data
    {
        public const int tileSize = 32;
        public static int screenW = 1200;
        public static int screenH = 900;

        public static void SetScreenSize(GraphicsDeviceManager graphics)
        {
            graphics.PreferredBackBufferWidth = screenW;
            graphics.PreferredBackBufferHeight = screenH;
            graphics.ApplyChanges();
        }
        public static void IncreaseScreenSize()
        {
            screenH += 10;
            SetScreenSize(Main.graphics);
        }
        public static void DecreaseScreenSize()
        {
            screenH -= 10;
            SetScreenSize(Main.graphics);
        }
        // Useful Math Functions
        public static float Approach(float current, float target, float increase)
        {
            if (current < target)
            {
                return MathF.Min(current + increase, target);
            }
            return MathF.Max(current - increase, target);
        }
        public static void DrawRectangle(this SpriteBatch spriteBatch, Rectangle rectangle, Color color)
        {
            Texture2D pixel = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);
            pixel.SetData(new[] { Color.White });

            spriteBatch.Draw(pixel, rectangle, color);
        }


        public static Color HexToColor(string hex)
        {
            hex = hex.Replace("#", "");
            byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            // Check if the hex string includes alpha (transparency) information
            byte a = 255; // Default alpha value
            if (hex.Length == 8)
            {
                a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
            }

            return new Color(r, g, b, a);
        }
        #region Catmull methods
        public static Vector2 parse_Vector2(string line)
        {
            int[] array = parse_ints(line);
            return new Vector2(array[0], array[1]);
        }
        public static int parse_int(string str)
        {
            if (!int.TryParse(str, out var result))
            {
                Console.WriteLine("Couldn't parse '" + str + "' to int");
            }

            return result;
        }

        public static int[] parse_ints(string str)
        {
            string[] array = str.Split(',');
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = parse_int(array[i]);
            }

            return array2;
        }
        #endregion
    }
    public static class SpriteBatchExtensions
    {
        public static void DrawLine(this SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color, float thickness = 1f)
        {
            Vector2 delta = end - start;
            float angle = (float)Math.Atan2(delta.Y, delta.X);
            float length = delta.Length();

            spriteBatch.Draw(Main.Pixel, start, null, color, angle, Vector2.Zero, new Vector2(length, thickness), SpriteEffects.None, 0);
        }
    }
}

