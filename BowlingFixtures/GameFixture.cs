
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;
namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void AllStrikes()
        {
            Game g = new Game();
            for (int i = 0; i < 12; i++)
                g.Roll(10);

            Assert.AreEqual(300, g.GetScore());

        }

        [TestMethod]
        public void FirstStrikeAndAllSpares()
        {
            Game g = new Game();
            
                g.Roll(10);
                for (int i = 0; i < 19; i++)
                    g.Roll(5);

            Assert.AreEqual(155, g.GetScore());

        }
        [TestMethod]
        public void AllSpares()
        {
            Game game = new Game();

            game.Roll(4);
            game.Roll(6);
            game.Roll(2);
            game.Roll(8);
            game.Roll(4);
            game.Roll(6);
            game.Roll(1);
            game.Roll(9);
            game.Roll(3);
            game.Roll(7);
            game.Roll(5);
            game.Roll(5);
            game.Roll(1);
            game.Roll(9);
            game.Roll(3);
            game.Roll(7);
            game.Roll(1);
            game.Roll(9);
            game.Roll(5);
            game.Roll(5);
            game.Roll(5);

            Assert.AreEqual(130, game.GetScore());

        }

        [TestMethod]
        public void AllZeros()
        {
            Game g = new Game();
            for (int i = 0; i < 12; i++)
                g.Roll(0);

            Assert.AreEqual(0, g.GetScore());

        }

        [TestMethod]
        public void SpareInBetween()
        {
            Game g = new Game();

            g.Roll(0);
            g.Roll(1);
            g.Roll(2);
            g.Roll(3);
            g.Roll(4);
            g.Roll(6);

            Assert.AreEqual(16, g.GetScore());

        }

        [TestMethod]
        public void RandomScore()
        {
            Game game = new Game();
            game.Roll(1);
            game.Roll(6);
            game.Roll(10);
            game.Roll(5);
            game.Roll(5);
            game.Roll(4);
            game.Roll(5);
            game.Roll(10);
            game.Roll(1);
            game.Roll(1);
            game.Roll(6);
            game.Roll(4);
            game.Roll(10);
            game.Roll(0);
            game.Roll(10);

            game.Roll(10);

            game.Roll(5);
            game.Roll(5);


            System.Diagnostics.Debug.WriteLine("value  :" + game.GetScore());
        }

        [TestMethod]
        public void NoStrikesAndSpare()
        {
            Game game = new Game();
            game.Roll(0);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);
            game.Roll(0);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);
            game.Roll(0);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);
            game.Roll(0);
            game.Roll(1);

            Assert.AreEqual(46, game.GetScore());
        }

        [TestMethod]
        public void StrikeatEnd()
        {
            Game game = new Game();

            game.Roll(4);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);
            game.Roll(0);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(1);
            game.Roll(3);
            game.Roll(10);
            game.Roll(5);
            game.Roll(4);

            Assert.AreEqual(67, game.GetScore());

        }

        [TestMethod]
        public void SpareAtEnd()
        {
            Game game = new Game();

            game.Roll(4);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);
            game.Roll(0);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(1);
            game.Roll(3);
            game.Roll(5);
            game.Roll(5);
            game.Roll(4);

            Assert.AreEqual(62, game.GetScore());

        }

       
    }




}