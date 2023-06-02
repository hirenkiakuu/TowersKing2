using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class Enemy : Unit
    {
        public Enemy(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {
            speed = 2.0f;
        }

        public virtual void Update(Vector2 OFFSET, Player player)
        {
            AI(player);

            base.Update(OFFSET);
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }

        public virtual void AI(Player player)
        {
            pos += Globals.RadialMove(player.pos, pos, speed);

            if (Globals.GetDistance(pos, player.pos) < 15)
            {
                player.GetHit(1);
                pos -= new Vector2(40, 40);
            }
        }

        public virtual void ChangeScore(int SCORE)
        {
            GameGlobals.score += SCORE;
        }

        public virtual void ChangeMana(float MANA)
        {
            GameGlobals.mana += MANA;
        }

    }
}
