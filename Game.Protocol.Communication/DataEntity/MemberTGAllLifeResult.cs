namespace Game.Protocol.Communication.DataEntity
{
    public class MemberTGAllLifeResult
    {
        /// <summary>
        /// 歷史總洗碼
        /// </summary>
        /// <returns></returns>
        public long HistoryTotalRollingPoint { get; set; }
        
        /// <summary>
        /// 歷史總輸贏
        /// </summary>
        /// <returns></returns>
        public long HistoryTotalResult { get; set; }
        
        /// <summary>
        /// 當天總洗碼
        /// </summary>
        /// <returns></returns>
        public long StatTotalRollingPoint { get; set; }
        
        /// <summary>
        /// 當天總輸贏
        /// </summary>
        /// <returns></returns>
        public long StatTotalResult { get; set; }
        
    }
}