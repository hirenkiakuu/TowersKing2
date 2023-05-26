using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class Unit : Basic2D
    {
        public float speed;
        public bool dead;
        public float hitDIst, health, healthMax;

        public Unit(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS) 
        {
            speed = 4.0f;
            dead = false;
            hitDIst = 35.0f;

            health = 1;
            healthMax = health;
        }

        public virtual void GetHit(float DAMAGE)
        {
            health -= DAMAGE;

            if (health <= 0)
                dead = true;
        }

        public virtual void Attack()
        { 
            
        }

        public override void Update(Vector2 OFFSET)
        {
            base.Update(OFFSET);
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
