// <copyright file="IBoardPrinter.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Interfaces
{
    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IPrinter" />.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// The PrintMessage.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        void PrintMessage(string message);
    }

    #endregion
}
