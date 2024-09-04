namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// 會員Avatar與等級資料
    /// </summary>
    public class MemberAvatarAndLevel
    {
        /// <summary>
        /// 會員ID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Avatar資料, 對應MemberAvatar這個class
        /// </summary>
        public string AvatarData { get; set; }

        /// <summary>
        /// 會員等級
        /// </summary>
        public int MemberLevel { get; set; }

        /// <summary>
        /// 會員暱稱
        /// </summary>
        public string NickName { get; set; }

    }
}
