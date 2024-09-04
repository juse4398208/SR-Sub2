namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// MemberAllLifeResult
    /// </summary>
    public class MemberAllLifeResult
    {
        /// <summary>
        /// MemberID會員編號
        /// </summary>
        public long MemberID { get; set; }
        /// <summary>
        /// Type資料類型(Type=0 不包含7PK資料 , Type=1 只有7PK資料)
        /// </summary>
        public int Type { get; set; }
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
