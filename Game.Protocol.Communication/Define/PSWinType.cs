namespace Game.Protocol.Communication
{
    /// <summary>
    /// PS WinType
    /// </summary>
    public enum PSWinType
    {
        /// <summary>
        /// 未中獎
        /// </summary>
        MissIt = 0,

        /// <summary>
        /// 中獎
        /// </summary>
        Win = 1,

        /// <summary>
        /// PS不存在
        /// </summary>
        PSNotExist = 2,

        /// <summary>
        /// 活動序號異常
        /// </summary>
        ActivitySerialAbnormal = 3,

        /// <summary>
        /// 活動未開啟
        /// </summary>
        ActivityNotOpen = 4,
    }
}
