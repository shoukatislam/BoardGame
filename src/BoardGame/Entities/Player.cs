// <copyright file="Player.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Entities
{
    using BoardGame.Interfaces;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Player" />.
    /// </summary>
    public class Player : IPlayer
    {
        #region Fields

        /// <summary>
        /// Defines the _positionReader.
        /// </summary>
        private IPositionReader _positionReader;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="positionReader">The positionReader<see cref="IPositionReader"/>.</param>
        public Player(IPositionReader positionReader)
        {
            _positionReader = positionReader;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the PositionX.
        /// </summary>
        public int PositionX { get; set; }

        /// <summary>
        /// Gets or sets the PositionY.
        /// </summary>
        public int PositionY { get; set; }

        /// <summary>
        /// Gets or sets the MinesHit.
        /// </summary>
        public int MinesHit { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Move.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string Move()
        {
            return _positionReader.NextPosition();
        }

        #endregion
    }

    #endregion
}
