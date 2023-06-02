using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowersKing
{
    public class UI
    {
        SpriteFont font;

        public QuantityDisplayBar healthBar;
        public QuantityDisplayBar manaBar;

        //public Button2D resetBtn; -- Возможно лишнее

        public UI(PassObject RESET) 
        {
            font = Globals.content.Load<SpriteFont>("fonts\\Arial16");

            healthBar = new QuantityDisplayBar(new Vector2(104, 40), 4, Color.Red);
            manaBar = new QuantityDisplayBar(new Vector2(104, 40), 4, Color.DarkBlue);

            //resetBtn = new Button2D("2d\\SimpleBtn", new Vector2(0,0), new Vector2(96, 32), 
            //    "fonts\\Arial16", "Reset", RESET, null);
        }

        public void Update(World WORLD)
        {
            healthBar.Update(WORLD.player.health, WORLD.player.healthMax);
            manaBar.Update(GameGlobals.mana, 1);
        }

        public void Draw(World WORLD)
        {
            string tempStr = "Score: " + GameGlobals.score;
            Vector2 strDims = font.MeasureString(tempStr);
            Globals.spriteBatch.DrawString(font, tempStr, new Vector2( 60, 60), 
                Color.Black,
                0.0f,
                new Vector2(0,0),
                1.5f,
                new SpriteEffects(),
                0.0f);

            healthBar.Draw(new Vector2(20, Globals.screenHeight - 80));
            manaBar.Draw(new Vector2(20, Globals.screenHeight - 140));

            if (WORLD.player.dead)
            {
                tempStr = "Press Enter to restart!";

                Globals.spriteBatch.DrawString(
                    font, 
                    tempStr,
                    new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), 
                    Color.Black,
                    0.0f,
                    new Vector2(0,0),
                    1.25f,
                    new SpriteEffects(),
                    0.0f);
            }
        }

    }
}
