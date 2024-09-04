namespace Game.Protocol.Communication.DataEntity
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ReserveSeatsInfoByGame
    /// </summary>
    public class ReserveSeatsInfoByGame
    {
        /// <summary>
        /// Gets or sets GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// ReserveSeatsInfos
        /// </summary>
        public List<ReserveSeatsInfo> ReserveSeatsInfos { get; set; }
    }
}
