// <copyright file="PositionConsoleReader.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame
{
    using BoardGame.Interfaces;
    using System;

    #region Classes

    /// <summary>
    /// Defines the <see cref="PositionConsoleReader" />.
    /// </summary>
    internal class PositionConsoleReader : IPositionReader
    {
        #region Public Methods

        /// <summary>
        /// The NextPosition.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string NextPosition()
        {
            Console.WriteLine("Please enter a position (U, D, L or R)");
            string position = Console.ReadLine();

            return position;
        }

        #endregion
    }

    #endregion
}
