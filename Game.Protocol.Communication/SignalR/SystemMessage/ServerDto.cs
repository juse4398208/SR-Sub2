namespace Game.Protocol.Communication.SignalR.SystemMessage
{
    /// <summary>
    /// 定義系統公告之 Dto (數據傳輸物件)
    /// </summary>
    public class ServerDto
    {
        /// <summary>
        /// 查詢可用公告
        /// </summary>
        public class QueryEnableSystemMessagesDto
        {
            /// <summary>
            /// 會員編號
            /// </summary>
            public long MemberID { get; set; }

            /// <summary>
            /// 帳號
            /// </summary>
            public string Account { get; set; }

            /// <summary>
            /// 語系
            /// </summary>
            public string Language { get; set; }
        }

        /// <summary>
        /// 公告已讀
        /// </summary>
        public class ReadSystemMessageDto
        {
            /// <summary>
            /// 公告編號
            /// </summary>
            public string Serial { get; set; }

            /// <summary>
            /// 會員編號
            /// </summary>
            public long MemberID { get; set; }
        }
        /// <summary>
        /// 查詢中獎回放影片
        /// </summary>
        public class QueryAwardVideoDto
        {
            /// <summary>
            /// 會員編號
            /// </summary>
            public long MemberID { get; set; }

            /// <summary>
            /// 帳號
            /// </summary>
            public string Account { get; set; }
        }

        /// <summary>
        /// 中獎回放影片已讀
        /// </summary>
        public class ReadAwardVideoDto
        {
            /// <summary>
            /// 注單號
            /// </summary>
            public string WagerSerial { get; set; }

            /// <summary>
            /// 會員編號
            /// </summary>
            public long MemberID { get; set; }
        }
    }
}
