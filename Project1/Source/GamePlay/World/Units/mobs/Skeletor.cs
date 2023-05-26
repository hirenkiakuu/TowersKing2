using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class Skeletor : Enemy
    {
        public Skeletor(Vector2 POS) 
            : base("2d\\skelet", POS, new Vector2(100, 100))
        {
            speed = 2.0f;
        }

        public override void Update(Vector2 OFFSET, Player player)
        {
            
            base.Update(OFFSET, player);
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
