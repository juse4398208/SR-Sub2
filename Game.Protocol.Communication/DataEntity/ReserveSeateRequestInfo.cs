namespace Game.Protocol.Communication.DataEntity
{
    using Microsoft.Build.Framework;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using Game.Protocol.Communication.Define;

    /// <summary>
    /// 保留作動作要求資料
    /// </summary>
    public class ReserveSeateRequestInfo
    {
        /// <summary>
        /// 執行時間，若無時間則填入當下時間
        /// </summary>
        public DateTime ActionTime { get; set; }

        /// <summary>
        /// 需要執行的遊戲ID
        /// </summary>
        public List<int> GameIDs { get; set; }

        /// <summary>
        /// 保留座請求的動作
        /// </summary>
        [Required]
        public ReserveSeateRequestAction Action { get; set; }

        /// <summary>
        /// 需要執行的會員ID
        /// </summary>
        public List<long> MemberIDs { get; set; }

        /// <summary>
        /// 需要執行的桌號
        /// </summary>
        public List<int> TableIDs { get; set; }

        /// <summary>
        /// 重製保留座後下一個步驟要做什麼(為了Web所做的合成命令)
        /// </summary>
        public ReserveSeatRequestNextAction NextAction { get; set; }
    }
}
