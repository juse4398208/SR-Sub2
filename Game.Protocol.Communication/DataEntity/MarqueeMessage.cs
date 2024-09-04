namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// MarqueeMessage 跑馬燈訊息
    /// </summary>
    public class MarqueeMessage
    {
        /// <summary>
        /// Gets or sets MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Gets or sets Account 玩家名稱
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets IsNPC
        /// </summary>
        public bool IsNPC { get; set; }

        /// <summary>
        /// Gets or sets IsAutoAward
        /// </summary>
        public bool IsAutoAward { get; set; }

        /// <summary>
        /// Gets or sets AwardID 獎項名稱
        /// </summary>
        public int AwardID { get; set; }

        /// <summary>
        /// Gets or sets WinTime 跑馬燈發布時間
        /// </summary>
        public double WinTime { get; set; }

        /// <summary>
        /// Gets or sets Denom 機台比率
        /// </summary>
        public double Denom { get; set; }

        /// <summary>
        /// Gets or sets BetPoint 押注
        /// </summary>
        public long BetPoint { get; set; }

        /// <summary>
        /// Gets or sets WinPoint 贏分
        /// </summary>
        public long WinPoint { get; set; }

        /// <summary>
        /// Gets or sets BeforeJPPoint 贏得前彩金點數
        /// </summary>
        public long BeforeJPPoint { get; set; }

        /// <summary>
        /// Gets or sets RebatePoint 回扣贈分
        /// </summary>
        public long RebatePoint { get; set; }

        /// <summary>
        /// Gets or sets Description 跑馬燈額外描述資料
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// MarqueeMessage 預設
        /// </summary>
        public MarqueeMessage()
        {
            this.Account = string.Empty;
            this.Description = string.Empty;
        }
    }
}
