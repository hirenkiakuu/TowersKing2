using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowersKing
{
    public class Player : Unit
    {
        Basic2D model;
       
        public Player(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {
            speed = 4.0f;
            health = 5;
        }

        public override void Update(Vector2 OFFSET)
        {
            //Управление
            var kstate = Keyboard.GetState();

            if (!dead)
            {
                if (kstate.IsKeyDown(Keys.W))
                    pos = new Vector2(pos.X, pos.Y - speed);

                if (kstate.IsKeyDown(Keys.S))
                    pos = new Vector2(pos.X, pos.Y + speed);

                if (kstate.IsKeyDown(Keys.A))
                    pos = new Vector2(pos.X - speed, pos.Y);

                if (kstate.IsKeyDown(Keys.D))
                    pos = new Vector2(pos.X + speed, pos.Y);

                if (kstate.IsKeyDown(Keys.Space))
                    Globals.passProjectile(new Sword(new Vector2(pos.X, pos.Y), new Vector2(100, 100), this));

                if (kstate.IsKeyDown(Keys.LeftShift) && GameGlobals.mana == 1)
                {
                    this.myModel.Name = "2d\\ability";
                    Globals.passProjectile(new Ability(new Vector2(pos.X, pos.Y), new Vector2(100, 100), this));
                    GameGlobals.mana = 0;
                    World.WipeEnemies();
                }


                //if (Globals.mouse.LeftClick()) Globals.passProjectile();
            }
            else
            {
                if (!(Globals.GetDistance(new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), pos) > 493))
                {
                    if (kstate.IsKeyDown(Keys.W))
                        pos = new Vector2(pos.X, pos.Y);

                    if (kstate.IsKeyDown(Keys.S))
                        pos = new Vector2(pos.X, pos.Y);

                    if (kstate.IsKeyDown(Keys.A))
                        pos = new Vector2(pos.X, pos.Y);

                    if (kstate.IsKeyDown(Keys.D))
                        pos = new Vector2(pos.X, pos.Y);
                }

                if (kstate.IsKeyDown(Keys.Space)) pos = new Vector2(pos.X, pos.Y);
            }


            if (Globals.GetDistance(new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), pos) > 493)
            {
                dead = true;
           
                pos.Y += 10;
            }
                
            base.Update(OFFSET);
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
