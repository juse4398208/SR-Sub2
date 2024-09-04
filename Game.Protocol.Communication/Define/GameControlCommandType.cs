namespace Game.Protocol.Communication
{
    /// <summary>
    /// GameControlCommandType
    /// </summary>
    public enum GameControlCommandType
    {
        /// <summary>
        /// 贏獎項
        /// </summary>
        WinAward = 0,

        /// <summary>
        /// 贏彩金
        /// </summary>
        WinJP = 1,

        /// <summary>
        /// Update module 更新機率模組
        /// </summary>
        UpdateModule = 2,

        /// <summary>
        /// NO_USE_3
        /// </summary>
        NO_USE_3 = 3,

        /// <summary>
        /// Update Member Setting 更新會員設定
        /// </summary>
        UpdateMemberSetting = 4,
    }
}
