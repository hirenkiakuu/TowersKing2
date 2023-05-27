#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using TowersKing;
#endregion

namespace TowersKing
{
    public delegate void PassObject(object i);
    public delegate object PassObjectAndReturn(object i);
    public class Globals
    {
        public static int gameState = 0;

        public static Random rand = new Random();

        public static System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

        public static ContentManager content;
        public static SpriteBatch spriteBatch;

        public static Effect normalEffect;

        public static PassObject passEnemy;
        public static PassObject passProjectile;
        public static PassObject passActiveItem;

        public static int screenWidth;
        public static int screenHeight;


        //public static McKeyboard keyboard;
        public static McMouseControl mouse;

        public static GameTime gameTime;


        public static float GetDistance(Vector2 pos, Vector2 target)
        {
            return (float)Math.Sqrt(Math.Pow(pos.X - target.X, 2) + Math.Pow(pos.Y - target.Y, 2));
        }

        public static Vector2 RadialMove(Vector2 focus, Vector2 pos, float speed)
        {
            float dist = Globals.GetDistance(pos, focus);

            if (dist <= speed) return focus - pos;
            else return (focus - pos) * speed / dist;
        }

        //RadialMove RotateTowards
    }
}
