namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// BagInfo
    /// </summary>
    public class BagInfo
    {
        /// <summary>
        /// 金額
        /// </summary>
        public long Money { get; set; }

        /// <summary>
        /// 數量
        /// </summary>
        public int CNT { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("(Credit: {0}, Quantity: {1})", this.Money, this.CNT);
        }
    }
}
