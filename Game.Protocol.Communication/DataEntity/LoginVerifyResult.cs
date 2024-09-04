namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// LoginVerifyResult
    /// 登入驗證結果
    /// </summary>
    public class LoginVerifyResult
    {
        public long MemberID { get; set; }

        public int Result { get; set; }
    }
}
