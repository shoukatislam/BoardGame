// <copyright file="Square.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Entities
{
    #region Classes

    /// <summary>
    /// Defines the <see cref="Square" />.
    /// </summary>
    public class Square
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether IsVisited.
        /// </summary>
        public bool IsVisited { get; set; }

        /// <summary>
        /// Gets the Letter.
        /// </summary>
        public virtual string Letter
        {
            get
            {
                if (IsVisited)
                {
                    return "[X]";
                }
                else
                {
                    return "[ ]";
                }
            }
        }

        /// <summary>
        /// Gets or sets the PositionX.
        /// </summary>
        public int PositionX { get; set; }

        /// <summary>
        /// Gets or sets the PositionY.
        /// </summary>
        public int PositionY { get; set; }

        #endregion
    }

    #endregion
}
