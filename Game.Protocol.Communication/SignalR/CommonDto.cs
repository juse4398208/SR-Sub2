namespace Game.Protocol.Communication.SignalR
{
    /// <summary>
    /// 定義通用訊息之 Dto (數據傳輸物件)
    /// </summary>
    public class CommonDto
    {
        /// <summary>
        /// 跟 Server端註冊
        /// </summary>
        public class RegistClientDto
        {
            public long MemberID { get; set; }
        }

        /// <summary>
        /// 跟 Server端解註冊
        /// </summary>
        public class UnRegistClientDto
        {
            public long MemberID { get; set; }
        }
    }
}
