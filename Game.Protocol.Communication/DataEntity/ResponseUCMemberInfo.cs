namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// 回傳給UC的所需會員資料
    /// </summary>
    public class ResponseUCMemberInfo
    {
        /// <summary>
        /// PlatformLoginData
        /// </summary>
        public ResponseUCMemberInfo()
        {
            MemberType = MemberType.Full;
        }

        /// <summary>
        /// 會員類型
        /// </summary>
        public MemberType MemberType { get; set; }
 
        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"MemberType: { this.MemberType }";
        }
    }
}
