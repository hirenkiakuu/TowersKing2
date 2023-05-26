using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class SharpEye : Enemy
    {
        public SharpEye(Vector2 POS)
            : base("2d\\sharpeye", POS, new Vector2(100, 100))
        {
            speed = 1.0f;
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