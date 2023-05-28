using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class HealingStar : ActiveItem
    {
        
        
        public HealingStar(Vector2 POS)
            : base("2d\\healingstar", POS, new Vector2(50, 50))
        {
            
        }

        //public override void AI(Player player)
        //{
        //    if (Globals.GetDistance(pos, player.pos) < 15)
        //    {
        //        player.GetHit(1);
        //    }

        //    base.AI(player);
        //}

        public virtual void Update(Vector2 OFFSET, World WORLD)
        {
            

            base.Update(OFFSET);
        }

        
        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}

