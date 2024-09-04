namespace Game.Protocol.Communication.Define
{
    /// <summary>
    /// 保留座的下一個步驟的列舉
    /// </summary>
    public enum ReserveSeatRequestNextAction
    {
        /// <summary>
        /// 沒動作
        /// </summary>
        NONE = 0,

        /// <summary>
        /// 啟動保留座
        /// </summary>
        TURNSTART = 1,

        /// <summary>
        /// 暫停保留座
        /// </summary>
        TURNSTOP = 2
    }
}
