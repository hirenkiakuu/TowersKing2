using Microsoft.Xna.Framework;
using TowersKing;

namespace Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void PlayerDefaultAttributesSet() 
        {
            var player = new Player(new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), new Vector2(100, 100));
            Assert.AreEqual(5, player.health);
            Assert.AreEqual(4.0f, player.speed);
        }

        [Test]
        public void CheckDeathOutsideArenaBounds()
        {
            Globals.screenWidth = 1920;
            Globals.screenHeight = 1080;

            var offset = new Vector2(0, 0);
            var player = new Player(offset, new Vector2(100, 100));
        
            player.Update(offset);
            Assert.AreEqual(true, player.dead);
        }
    }

    [TestFixture]
    public class WorldTests
    {
        [Test]
        public void WorldTest1()
        {
            var game = new Game1();
            var gamePlay = new GamePlay(game.ChangeGameState);

            Assert.AreEqual(0, gamePlay.playState);
        }
    }

    //[TestFixture]
    //public class GameProcess
    //{
    //    [Test]
    //    public void StartGame() 
    //    {
    //        using var game = new TowersKing.Game1();
    //        game.Run();
            
    //        game.Exit();


    //        Assert.AreEqual(1920, Globals.screenWidth);
    //    }

    //    //public void StartWithMainMenu()
    //    //{
    //    //    using var game = new TowersKing.Game1();
    //    //    game.Run();

    //    //    Assert.AreEqual();
    //    //}
    //}
}