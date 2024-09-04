namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// KickMemberInfo
    /// </summary>
    public class KickMemberInfo
    {
        /// <summary>
        /// Gets or sets MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Gets or sets GameSerial
        /// </summary>
        public string GameSerial { get; set; }

        /// <summary>
        /// Gets or sets MemberCloneID
        /// </summary>
        public int MemberCloneID { get; set; }

        /// <summary>
        /// Gets or sets Result
        /// </summary>
        public bool Result { get; set; }
    }
}
