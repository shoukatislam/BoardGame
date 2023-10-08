// <copyright file="IPlayer.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Interfaces
{
    using BoardGame.Entities;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IPlayer" />.
    /// </summary>
    public interface IPlayer
    {
        #region Properties

        /// <summary>
        /// Gets or sets the PositionX.
        /// </summary>
        int PositionX { get; set; }

        /// <summary>
        /// Gets or sets the PositionY.
        /// </summary>
        int PositionY { get; set; }

        /// <summary>
        /// Gets or sets the MinesHit.
        /// </summary>
        int MinesHit { get; set; }

        #endregion

        /// <summary>
        /// The Move.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        string Move();
    }

    #endregion
}
