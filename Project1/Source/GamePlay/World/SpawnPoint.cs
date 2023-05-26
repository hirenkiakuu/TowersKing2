using Microsoft.Xna.Framework;

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
                SpawnEnemy();
                spawnTimer.ResetToZero();
            }

            base.Update(OFFSET);
        }

        public virtual void GetHit()
        {
            dead = true;
        }

        public virtual void SpawnEnemy()
        {
            Globals.passEnemy(new Skeletor(new Vector2(pos.X, pos.Y)));
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
