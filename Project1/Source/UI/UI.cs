using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using vec = Microsoft.Xna.Framework;

namespace TowersKing
{
    public class UI
    {
        SpriteFont font;

        public QuantityDisplayBar healthBar;

        //public Button2D resetBtn; -- Возможно лишнее

        public UI(PassObject RESET) 
        {
            font = Globals.content.Load<SpriteFont>("fonts\\Arial16");

            healthBar = new QuantityDisplayBar(new Microsoft.Xna.Framework.Vector2(104, 40), 4, Color.Red);

            //resetBtn = new Button2D("2d\\SimpleBtn", new Vector2(0,0), new Vector2(96, 32), 
            //    "fonts\\Arial16", "Reset", RESET, null);
        }

        public void Update(World WORLD)
        {
            healthBar.Update(WORLD.player.health, WORLD.player.healthMax);
        }

        public void Draw(World WORLD)
        {
            healthBar.Draw(new Microsoft.Xna.Framework.Vector2(20, Globals.screenHeight - 80));

            if (WORLD.player.dead)
            {
                var tempStr = "Press Enter to restart";

                Globals.spriteBatch.DrawString(
                    font, 
                    tempStr,
                    new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), 
                    Color.Black,
                    0.0f,
                    new vec.Vector2(0,0),
                    1.25f,
                    new SpriteEffects(),
                    0.0f);
            }
        }

    }
}
