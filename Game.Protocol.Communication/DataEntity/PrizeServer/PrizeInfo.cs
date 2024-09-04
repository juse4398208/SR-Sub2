namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// PrizeInfo
    /// </summary>
    public class PrizeInfo
    {
        /// <summary>
        /// 總金額
        /// </summary>
        public long TotalCredit { get; set; }

        /// <summary>
        /// TotalBags
        /// </summary>
        public int TotalBags { get; set; }

        /// <summary>
        /// 獎項列表
        /// </summary>
        public List<BagInfo> Bags { get; set; }
    }
}
