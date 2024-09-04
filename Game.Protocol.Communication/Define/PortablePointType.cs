namespace Game.Protocol.Communication
{
    /// <summary>
    /// 借款型別
    /// </summary>
    public enum PortablePointType
    {
        /// <summary>
        /// 借(-)
        /// </summary>
        Advance = 0,

        /// <summary>
        /// 還(+)
        /// </summary>
        Return = 1,

        /// <summary>
        /// 確認交易結束
        /// </summary>
        ConfirmEnd = 2,
    }
}
