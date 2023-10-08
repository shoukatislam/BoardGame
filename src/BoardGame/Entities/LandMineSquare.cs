// <copyright file="LandMineSquare.cs">
// Copyright (c) 2023 All Rights Reserved
// </copyright>

namespace BoardGame.Entities
{
    #region Classes

    /// <summary>
    /// Defines the <see cref="LandMineSquare" />.
    /// </summary>
    public class LandMineSquare : Square
    {
        #region Properties

        /// <summary>
        /// Gets the Letter.
        /// </summary>
        public override string Letter
        {
            get
            {
                if (IsVisited)
                {
                    return "[M]";
                }
                else
                {
                    return "[ ]";
                }
            }
        }

        #endregion
    }

    #endregion
}
