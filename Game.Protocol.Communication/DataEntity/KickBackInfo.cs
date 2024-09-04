namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// KickBack Info
    /// </summary>
    public class KickBackInfo
    {
        #region Property

        /// <summary>
        /// Gets or sets GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Gets or sets MerchantID
        /// </summary>
        public int MerchantID { get; set; }

        /// <summary>
        /// Gets or sets StationID
        /// </summary>
        public int StationID { get; set; }

        /// <summary>
        /// Gets or sets AgentMemberLevel
        /// </summary>
        public int AgentMemberLevel { get; set; }

        /// <summary>
        /// Gets or sets KickBackRate
        /// </summary>
        public int KickBackRate { get; set; }

        #endregion Property
    }
}
