// <copyright file="IBoard.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Interfaces
{
    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IBoard" />.
    /// </summary>
    public interface IBoard
    {
        #region Properties

        /// <summary>
        /// Gets a value indicating whether IsFinished.
        /// </summary>
        bool IsFinished { get; }

        #endregion

        /// <summary>
        /// The NextMove.
        /// </summary>
        void NextMove();

        /// <summary>
        /// The PrintBoard.
        /// </summary>
        void PrintBoard();
    }

    #endregion
}
