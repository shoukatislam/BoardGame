// <copyright file="Board.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame
{
    using BoardGame.Entities;
    using BoardGame.Interfaces;
    using System;
    using System.Text;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Board" />.
    /// </summary>
    public class Board : IBoard
    {
        #region Fields

        /// <summary>
        /// Defines the player.
        /// </summary>
        private readonly IPlayer player;

        /// <summary>
        /// Defines the printer.
        /// </summary>
        private readonly IPrinter printer;

        /// <summary>
        /// Defines the boardOptions.
        /// </summary>
        private readonly BoardOptions boardOptions;

        /// <summary>
        /// Defines the boardGame.
        /// </summary>
        private Square[,] boardGame;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="printer">The printer<see cref="IPrinter"/>.</param>
        /// <param name="player">The player<see cref="IPlayer"/>.</param>
        /// <param name="boardOptions">The boardOptions<see cref="BoardOptions"/>.</param>
        public Board(IPrinter printer, IPlayer player, BoardOptions boardOptions = null)
        {
            this.boardOptions = boardOptions ?? new BoardOptions();
            this.printer = printer;
            this.player = player;
            this.boardGame = new Square[this.boardOptions.SizeX, this.boardOptions.SizeY];

            this.Initialise();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets a value indicating whether IsFinished.
        /// </summary>
        public bool IsFinished
        {
            get
            {
                return (player.MinesHit > boardOptions.MaxMinesHits || player.PositionY == (boardOptions.SizeY - 1));
            }
        }

        /// <summary>
        /// Gets a value indicating whether IsWon.
        /// </summary>
        public bool IsWon
        {
            get
            {
                return (player.MinesHit <= boardOptions.MaxMinesHits && player.PositionY == (boardOptions.SizeY - 1));
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Initialise.
        /// </summary>
        public void Initialise()
        {
            this.InitialiseBoard();
            this.InitialiseMines();

            this.boardGame[0, 0].IsVisited = true;
        }

        /// <summary>
        /// The NextMove.
        /// </summary>
        public void NextMove()
        {
            var playerMove = this.player.Move();

            switch (playerMove.ToLower())
            {
                case "u":
                    if (player.PositionY < 1)
                    {
                        Console.WriteLine("Invalid move");
                    }
                    --player.PositionY;

                    break;
                case "d":
                    if (player.PositionY > (boardOptions.SizeY - 1))
                    {
                        Console.WriteLine("Invalid move");
                    }
                    ++player.PositionY;
                    break;
                case "l":
                    if (player.PositionX < 1)
                    {
                        Console.WriteLine("Invalid move");
                    }
                    --player.PositionX;
                    break;
                case "r":
                    if (player.PositionX > (boardOptions.SizeX - 1))
                    {
                        Console.WriteLine("Invalid move");
                    }
                    ++player.PositionX;
                    break;
                default:
                    Console.WriteLine("Invalid move");
                    return;
            }

            var selectedBox = this.boardGame[player.PositionY, player.PositionX];
            selectedBox.IsVisited = true;
            if(selectedBox is LandMineSquare)
            {
                player.MinesHit++;
            }
        }

        /// <summary>
        /// The PrintBoard.
        /// </summary>
        public void PrintBoard()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    builder.Append(boardGame[i, j].Letter);
                }
                builder.AppendLine();
            }

            this.printer.PrintMessage(builder.ToString());
            this.printer.PrintMessage($"Mines hit = {this.player.MinesHit}");

            if (this.IsFinished)
            {
                if (this.IsWon)
                {
                    this.printer.PrintMessage("Player has won!!");
                }
                else
                {
                    this.printer.PrintMessage("Player has lost!!");
                }
            }
        }

        #endregion

        /// <summary>
        /// The InitialiseBoard.
        /// </summary>
        protected virtual void InitialiseBoard()
        {
            for (int i = 0; i < boardOptions.SizeX; i++)
            {
                for (int j = 0; j < boardOptions.SizeY; j++)
                {
                    boardGame[i, j] = boardGame[i, j] ?? new Square()
                    {
                        IsVisited = false,
                        PositionX = i,
                        PositionY = j
                    };
                }
            }
        }

        /// <summary>
        /// The InitialiseMines.
        /// </summary>
        protected virtual void InitialiseMines()
        {
            Random rnd = new();

            int numberOfMines = boardOptions.MaxMines ?? rnd.Next(1, boardGame.Length-1);

            for (int i = 0; i < numberOfMines; i++)
            {
                int x = rnd.Next(0, boardOptions.SizeX - 1);
                int y = rnd.Next(0, boardOptions.SizeY - 1);

                if (x != 0 && y != 0)
                {
                    boardGame[x, y] = new LandMineSquare()
                    {
                        IsVisited = false,
                        PositionX = x,
                        PositionY = y
                    };
                }
            }
        }
    }

    #endregion
}
