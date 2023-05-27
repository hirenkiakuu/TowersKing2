using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class HealingStar : ActiveItem
    {
        public bool isTaken;
        public int bonusNumber;
        public HealingStar(Vector2 POS)
            : base("2d\\healingstar", POS, new Vector2(50, 50))
        {
            isTaken = false;
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

        public virtual void DoEffect(World WORLD)
        {
            if (done && WORLD.player.health < 5) WORLD.player.health += 1;
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}

