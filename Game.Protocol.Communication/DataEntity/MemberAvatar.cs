namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Avatar資料
    /// </summary>
    public class MemberAvatar
    {
        /// <summary>
        /// 是否為預設Avatar
        /// </summary>
        public bool IsSysAvatar { get; set; }

        /// <summary>
        /// Avatar編號
        /// </summary>
        public int AvatarNo { get; set; }

        /// <summary>
        /// Avatar URL
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 會員暱稱
        /// </summary>
        public string MemberNickname { get; set; }
    }
}
