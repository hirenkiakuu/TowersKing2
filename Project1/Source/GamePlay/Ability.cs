using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class Ability : Projectile2d
    {
        public Ability(Vector2 POS, Vector2 DIMS, Unit OWNER)
            : base("2d\\ability", POS, DIMS, OWNER)
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {

        }
    }
}
