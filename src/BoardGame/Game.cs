// <copyright file="Game.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame
{
    using BoardGame.Entities;
    using BoardGame.Interfaces;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Game" />.
    /// </summary>
    public class Game
    {
        #region Fields

        /// <summary>
        /// Defines the board.
        /// </summary>
        private IBoard board;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="board">The board<see cref="IBoard"/>.</param>
        public Game()
        {
            IPositionReader consolePositionReader = new PositionConsoleReader();
            IPlayer player = new Player(consolePositionReader);
            IPrinter boardPrinter = new ConsolePrinter();

            this.board = new Board(boardPrinter, player, new BoardOptions());
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Start.
        /// </summary>
        public void Start()
        {
            while (!this.board.IsFinished)
            {
                // print the board
                this.board.PrintBoard();

                // ask the player to move
                this.board.NextMove();
            }

            // print the end board
            this.board.PrintBoard();
        }

        #endregion
    }

    #endregion
}
