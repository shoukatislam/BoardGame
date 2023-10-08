using Moq;
using BoardGame.Interfaces;
using Shouldly;
using BoardGame.Entities;

namespace BoardGame.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Player_Move_Up_Test_SuccessExpected()
        {
            var mockPositionReader = new Mock<IPositionReader>();
            mockPositionReader.Setup(x => x.NextPosition()).Returns("U");

            var board = new Player(mockPositionReader.Object);
            var move= board.Move();

            move.ShouldBe("U");

            mockPositionReader.VerifyAll();
        }

        [TestMethod]
        public void Player_Move_Down_Test_SuccessExpected()
        {
            var mockPositionReader = new Mock<IPositionReader>();
            mockPositionReader.Setup(x => x.NextPosition()).Returns("D");

            var board = new Player(mockPositionReader.Object);
            var move = board.Move();

            move.ShouldBe("D");

            mockPositionReader.VerifyAll();
        }
    }
}