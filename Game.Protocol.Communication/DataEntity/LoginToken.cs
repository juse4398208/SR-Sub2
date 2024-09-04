namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// LoginToken
    /// 登入 PNG 的隨機 Token
    /// </summary>
    public class LoginToken
    {
        public long MemberID { get; set; }

        public string Token { get; set; }
    }
}
