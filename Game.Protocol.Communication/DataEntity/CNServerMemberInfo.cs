namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// ServerMemberInfo
    /// </summary>
    public class CNServerMemberInfo
    { 
        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        public string Account { get; set; }
        
        /// <summary>
        /// NickName
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// MemberType
        /// </summary>
        public int MemberTypeID { get; set; }

        /// <summary>
        /// MemberLevelID
        /// </summary>
        public int MemberLevelID { get; set; }
    }
}
