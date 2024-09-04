namespace Game.Protocol.Communication.Define
{
    /// <summary>
    /// 保留座請求動作列舉
    /// </summary>
    public enum ReserveSeateRequestAction
    {
        /// <summary>
        /// 重置
        /// </summary>
        RESET = 0,

        /// <summary>
        /// 啟動
        /// </summary>
        START = 1,

        /// <summary>
        /// 暫停
        /// </summary>
        STOP = 2,

        /// <summary>
        /// 刪除
        /// </summary>
        DELETE = 3,
    }
}
