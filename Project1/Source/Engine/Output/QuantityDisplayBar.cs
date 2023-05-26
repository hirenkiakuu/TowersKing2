using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class QuantityDisplayBar
    {
        public int boarder;

        public Basic2D bar, barBkg;

        public Color color;

        public QuantityDisplayBar(Vector2 DIMS, int BOARDER, Color COLOR)
        {
            boarder = BOARDER; 
            color = COLOR;

            bar = new Basic2D("2d\\solid", new Vector2(0,0), new Vector2(DIMS.X - boarder * 2, DIMS.Y - boarder * 2));
            barBkg = new Basic2D("2d\\shade", new Vector2(0, 0), new Vector2(DIMS.X, DIMS.Y));
        }

        public virtual void Update(float CURRENT, float MAX)
        {
            bar.dims = new Vector2(CURRENT / MAX * (barBkg.dims.X - boarder * 2), bar.dims.Y);
        }

        public virtual void Draw(Vector2 OFFSET)
        {
            barBkg.Draw(OFFSET, new Vector2(0,0), Color.Black);
            bar.Draw(OFFSET + new Vector2(boarder, boarder), new Vector2(0,0), color);
        }
    }
}
