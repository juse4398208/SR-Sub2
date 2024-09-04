namespace Game.Protocol.Communication.DataEntity
{
    using System;

    /// <summary>
    /// 注單格式
    /// </summary>
    public class WagerInfo
    {
        /// <summary>
        /// 單號
        /// </summary>
        public string WagerSerial { get; set; }

        /// <summary>
        /// 會員ID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// 遊戲類別
        /// </summary>
        public int GameCategoryID { get; set; }

        /// <summary>
        /// 遊戲ID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// 桌號
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// 局數
        /// </summary>
        public long RoundID { get; set; }

        /// <summary>
        /// 廳別
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// 下注值
        /// </summary>
        public long BetPoint { get; set; }

        /// <summary>
        /// 贏金
        /// </summary>
        public long WinPoint { get; set; }

        /// <summary>
        /// 注單時間
        /// </summary>
        public DateTime WagerDateTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否異常
        /// </summary>
        public bool IsAnomaly { get; set; }

        /// <summary>
        /// 通訊頻道ID
        /// </summary>
        public int ChannelID { get; set; }

        /// <summary>
        /// 原先點數
        /// </summary>
        public long BeforePoint { get; set; }

        /// <summary>
        /// 剩餘點數
        /// </summary>
        public long AfterPoint { get; set; }

        /// <summary>
        /// 洗碼量(有效下注額)
        /// </summary>
        public long RollingPoint { get; set; }

        /// <summary>
        /// 平台ID
        /// </summary>
        public int PlatformID { get; set; }

        /// <summary>
        /// 公點
        /// </summary>
        public long TaxPoint { get; set; }

        /// <summary>
        /// 底注
        /// </summary>
        public long Ante { get; set; }

        /// <summary>
        /// 該注單是否有使用道具卡
        /// </summary>
        public bool IsItemCard { get; set; }

        /// <summary>
        /// 會員帳號
        /// </summary>
        public string MemberAccount { get; set; }

        /// <summary>
        /// 會員類型
        /// </summary>
        public int MemberTypeID { get; set; }

        /// <summary>
        /// 平台的MemberID
        /// </summary>
        public long SrcMemberID { get; set; }

        /// <summary>
        /// DateWager
        /// </summary>
        public DateTime DateWager { get; set; }

        /// <summary>
        /// DateBill
        /// </summary>
        public DateTime DateBill { get; set; }

        /// <summary>
        /// 是否已補單(0尚未處理、1已處理)
        /// </summary>
        public bool IsProcess { get; set; } = false;
    }
}
