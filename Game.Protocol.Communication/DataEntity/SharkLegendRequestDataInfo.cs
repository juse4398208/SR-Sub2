namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// SharkLegend Response Data
    /// </summary>
    public sealed class SharkLegendRequestDataInfo
    {
        /// <summary>
        /// Gets or sets Member ID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Gets or sets Module ID
        /// </summary>
        public string GameModuleID { get; set; }

        /// <summary>
        /// Gets or sets Rate ID
        /// </summary>
        public double Rate { get; set; }

        /// <summary>
        /// Gets or sets GameData
        /// </summary>
        public string GameData { get; set; }

        /// <summary>
        /// Gets or sets MemberData
        /// </summary>
        public string MemberData { get; set; }
    }
}
