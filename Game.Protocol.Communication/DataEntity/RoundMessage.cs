namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Round Message
    /// </summary>
    public class RoundMessage
    {
        /// <summary>
        /// Gets or sets RoundID
        /// </summary>
        public long RoundID { get; set; }

        /// <summary>
        /// Gets or sets MemberInfo
        /// </summary>
        public string MemberInfo { get; set; }

        /// <summary>
        /// Gets or sets GameInfo
        /// </summary>
        public string GameInfo { get; set; }

        /// <summary>
        /// Gets or sets ProbInfo
        /// </summary>
        public string ProbInfo { get; set; }

        /// <summary>
        /// Gets or sets StatisticalInfo
        /// </summary>
        public string StatisticalInfo { get; set; }

        /// <summary>
        /// Gets or sets StatisticalHistory
        /// </summary>
        public string StatisticalHistory { get; set; }
    }
}
