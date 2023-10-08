// <copyright file="IReader.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Interfaces
{
    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IPositionReader" />.
    /// </summary>
    public interface IPositionReader
    {
        /// <summary>
        /// The NextPosition.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        string NextPosition();
    }

    #endregion
}
