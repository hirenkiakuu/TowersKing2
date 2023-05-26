using Microsoft.Xna.Framework;
using System;

namespace TowersKing
{
    public class SpawnPoint : Basic2D
    {
        
        public bool dead;
        public float hitDIst;
        public McTimer spawnTimer = new McTimer(4000);

        public SpawnPoint(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS) 
        {
            
            dead = false;
            hitDIst = 35.0f;
        }

        public override void Update(Vector2 OFFSET)
        {
            spawnTimer.UpdateTimer();

            if (spawnTimer.Test())
            {
                var rnd = new Random();
                var randInt = rnd.Next(0, 10);

                SpawnEnemy(randInt);
                spawnTimer.ResetToZero();
            }

            base.Update(OFFSET);
        }

        public virtual void GetHit()
        {
            dead = true;
        }

        public virtual void SpawnEnemy(int randInt)
        {
            //Globals.passEnemy(new Skeletor(new Vector2(pos.X, pos.Y)));

            //var rnd = new Random();
            //var a1 = rnd.Next(0, 1);

            if (randInt == 0) Globals.passEnemy(new Skeletor(new Vector2(pos.X, pos.Y)));
            else Globals.passEnemy(new SharpEye(new Vector2(pos.X, pos.Y)));
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
