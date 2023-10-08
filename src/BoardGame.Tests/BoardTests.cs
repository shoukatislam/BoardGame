using Moq;
using BoardGame.Interfaces;
using Shouldly;

namespace BoardGame.Tests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void Board_Print_Blank_Board_SuccessExpected()
        {
            var mockBoardPrinter = new Mock<IPrinter>();
            mockBoardPrinter.Setup(x => x.PrintMessage(It.IsAny<string>()));

            var mockPlayer = new Mock<IPlayer>(); 

            var board = new Board(mockBoardPrinter.Object, mockPlayer.Object);
            board.PrintBoard();

            board.IsWon.ShouldBeFalse();

            mockBoardPrinter.Verify(x => x.PrintMessage(It.IsAny<string>()),Times.Exactly(2));
        }

        [TestMethod]
        public void Board_NoMines_NextMove_Won_SuccessExpected()
        {
            var mockBoardPrinter = new Mock<IPrinter>();            

            var mockPlayer = new Mock<IPlayer>();
            mockPlayer.Setup(x => x.Move()).Returns("d");


            var board = new Board(mockBoardPrinter.Object, mockPlayer.Object, new Entities.BoardOptions() { SizeX = 1, SizeY = 1, MaxMines=0 });
            board.NextMove();

            board.IsWon.ShouldBeTrue();
            board.IsFinished.ShouldBeTrue();
            mockPlayer.VerifyAll();
        }

    }
}