namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Fish Table Key
    /// </summary>
    public sealed class FishTableKey
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
    }
}
