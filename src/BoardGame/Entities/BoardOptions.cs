// <copyright file="BoardOptions.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Entities
{
    #region Classes

    /// <summary>
    /// Defines the <see cref="BoardOptions" />.
    /// </summary>
    public class BoardOptions
    {
        #region Properties

        /// <summary>
        /// Gets or sets the MaxMines.
        /// </summary>
        public int? MaxMines { get; set; }

        /// <summary>
        /// Gets or sets the MaxMinesHits.
        /// </summary>
        public int MaxMinesHits { get; set; } = 2;

        /// <summary>
        /// Gets or sets the SizeX.
        /// </summary>
        public int SizeX { get; set; } = 8;

        /// <summary>
        /// Gets or sets the SizeY.
        /// </summary>
        public int SizeY { get; set; } = 8;

        #endregion
    }

    #endregion
}
