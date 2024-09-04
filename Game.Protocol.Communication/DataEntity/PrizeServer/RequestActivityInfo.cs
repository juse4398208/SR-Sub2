namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// RequestActivityInfo
    /// </summary>
    public class RequestActivityInfo
    {
        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// GameSerial
        /// </summary>
        public string GameSerial { get; set; }
    }
}
