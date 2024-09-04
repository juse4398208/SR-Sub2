namespace Game.Protocol.Communication.DataEntity
{
    using System;

    /// <summary>
    /// 玩家歷史投注資訊紀錄
    /// </summary>
    public class MemberAllLifeRecord
    {
        /// <summary>
        /// MemberID會員編號
        /// </summary>
        public long MemberID { get; set; }
        /// <summary>
        /// 資料更新時間
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// TotalRollingPoint總洗碼量
        /// </summary>
        public long TotalRollingPoint { get; set; }
        /// <summary>
        /// TotalResult總輸贏
        /// </summary>
        public long TotalResult { get; set; }
    }
}
