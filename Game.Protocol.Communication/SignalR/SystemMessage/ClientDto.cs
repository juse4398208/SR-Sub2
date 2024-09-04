namespace Game.Protocol.Communication.SignalR.SystemMessage
{
    using System.Collections.Generic;
    /// <summary>
    /// 定義系統公告之 Dto (數據傳輸物件)
    /// </summary>
    public class ClientDto
    {
        /// <summary>
        /// 回覆公告內容
        /// </summary>
        public class ResponseSystemMessageDto
        {
            /// <summary>
            /// 公告編號
            /// </summary>
            public string Serial { get; set; }

            /// <summary>
            /// 會員編號
            /// </summary>
            public long MemberID { get; set; }

            /// <summary>
            /// 語系
            /// </summary>
            public string Language { get; set; }

            /// <summary>
            /// 公告訊息
            /// </summary>
            public string Message { get; set; }

            /// <summary>
            /// 公告訊息
            /// </summary>
            public IEnumerable<int> GameList { get; set; }
        }

        /// <summary>
        /// 通知公告停用
        /// </summary>
        public class SystemMessageDisableDto
        {
            /// <summary>
            /// 公告編號
            /// </summary>
            public string Serial { get; set; }
        }

        /// <summary>
        /// 回覆公告內容
        /// </summary>
        public class EnableSystemMessageDto
        {
            /// <summary>
            /// 公告編號
            /// </summary>
            public string Serial { get; set; }

            /// <summary>
            /// 語系
            /// </summary>
            public string Language { get; set; }

            /// <summary>
            /// 公告訊息
            /// </summary>
            public string Message { get; set; }

            /// <summary>
            /// 公告訊息
            /// </summary>
            public IEnumerable<int> GameList { get; set; }
        }

        /// <summary>
        /// 回覆中獎影片內容
        /// </summary>
        public class ResponseAwardVideoDto
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
            /// 注單編號
            /// </summary>
            public string WagerSerial { get; set; }
        }
    }
}
