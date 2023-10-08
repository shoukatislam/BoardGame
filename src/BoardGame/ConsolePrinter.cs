// <copyright file="ConsolePrinter.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame
{
    using BoardGame.Entities;
    using BoardGame.Interfaces;
    using System;

    #region Classes

    /// <summary>
    /// Defines the <see cref="ConsolePrinter" />.
    /// </summary>
    internal class ConsolePrinter : IPrinter
    {
        #region Public Methods       

        /// <summary>
        /// The PrintMessage.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        #endregion
    }

    #endregion
}
