namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// request Data
    /// </summary>
    public class CheckPointDataInfo
    {
        /// <summary>
        /// Gets or sets MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Gets or sets Direction
        /// </summary>
        public int Direction { get; set; }

        /// <summary>
        /// Gets or sets PointSwitch
        /// </summary>
        public long PointSwitch { get; set; }

        /// <summary>
        /// Gets or sets ClientToken
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// GameSerial
        /// </summary>
        public string GameSerial { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        public string Account { get; set; }
    }
}
