using Moq;
using BoardGame.Interfaces;
using Shouldly;
using BoardGame.Entities;

namespace BoardGame.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void Square_Free_Test_SuccessExpected()
        {
            var square = new Square()
            {
                IsVisited = false,
            };

            square.Letter.ShouldBe("[ ]");
        }

        [TestMethod]
        public void Square_Visited_Test_SuccessExpected()
        {
            var square = new Square()
            {
                IsVisited = true,
            };

            square.Letter.ShouldBe("[X]");
        }

        [TestMethod]
        public void Square_Mine_Visited_Test_SuccessExpected()
        {
            var square = new LandMineSquare()
            {
                IsVisited = true,
            };

            square.Letter.ShouldBe("[M]");
        }

        [TestMethod]
        public void Square_Mine_NotVisited_Test_SuccessExpected()
        {
            var square = new LandMineSquare()
            {
                IsVisited = false,
            };

            square.Letter.ShouldBe("[ ]");
        }
    }
}