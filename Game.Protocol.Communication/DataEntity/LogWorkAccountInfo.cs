namespace Game.Protocol.Communication.DataEntity
{
    public class LogWorkAccountInfo
    {
        /// <summary>
        /// MongoDB _objectId
        /// </summary>
        public string WorkAccountID { get; set; }

        /// <summary>
        /// MongoDB Details > ID
        /// </summary>
        public string WorkAccountDetailID { get; set; }

        /// <summary>
        /// 投注金額
        /// </summary>
        public long BetPoint { get; set; }

        /// <summary>
        /// 派彩金額
        /// </summary>
        public long AwardPoint { get; set; }

        /// <summary>
        /// 派彩結果
        /// </summary>
        public int AwardStatus { get; set; }

        /// <summary>
        /// 反水欄位
        /// </summary>
        public long KickBackPoint { get; set; }
    }
}
