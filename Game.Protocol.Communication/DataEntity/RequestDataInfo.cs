namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// request Data
    /// </summary>
    public class RequestDataInfo
    {
        /// <summary>
        /// Gets or sets Game ID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Gets or sets MerchantID
        /// </summary>
        public int MerchantID { get; set; }

        /// <summary>
        /// Gets or sets Station ID
        /// </summary>
        public int StationID { get; set; }

        /// <summary>
        /// Gets or sets Agent Member Level
        /// </summary>
        public int AgentMemberLevel { get; set; }
    }
}
