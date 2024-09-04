namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// UpdateMemberLevel
    /// </summary>
    public class UpdateMemberLevel
    {
        /// <summary>
        /// Gets or sets MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Gets or sets TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// Gets or sets MemberLevel
        /// </summary>
        public int MemberLevel { get; set; }
    }
}
