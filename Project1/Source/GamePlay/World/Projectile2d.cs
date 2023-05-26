using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TowersKing
{
    public class Projectile2d : Basic2D
    {
        public float speed;
        public Unit owner;
        public Vector2 direction;
        public bool done;

        public Projectile2d(string PATH, Vector2 POS, Vector2 DIMS, Unit OWNER) 
            : base(PATH, POS, DIMS)
        {
            done = false;

            speed = 5.0f;

            owner = OWNER;

            direction.Normalize();
        }

        public virtual void Update(Vector2 OFFSET, List<Unit> UNITS)
        {

            if (HitSomething(UNITS))
                done = true;
        }

        public virtual bool HitSomething(List<Unit> UNITS)
        {
            //Пока что false

            for (int i = 0; i < UNITS.Count; i++)
            {
                if (Globals.GetDistance(pos, UNITS[i].pos) < UNITS[i].hitDIst)
                {
                    UNITS[i].GetHit(5);
                    return true;
                }
            }

            return false;
        }

    }
}
