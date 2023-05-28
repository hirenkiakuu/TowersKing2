using Microsoft.Xna.Framework;

namespace TowersKing
{
    public class GamePlay
    {
        public int playState;

        World world;

        PassObject ChangeGameState;

        public GamePlay(PassObject CHANGEGAMESTATE)
        {
            playState = 0;

            ChangeGameState = CHANGEGAMESTATE;
            ResetWorld(null);
        }

        public virtual void Update()
        {
            if (playState == 0)
            {
                world.Update();
            }
        }

        public virtual void ResetWorld(object INFO)
        {
            world = new World(ResetWorld, ChangeGameState, 0);
        }

        public virtual void Draw()
        {
            if (playState == 0)
            {
                world.Draw(Vector2.Zero);
            }
        }

    }
}
