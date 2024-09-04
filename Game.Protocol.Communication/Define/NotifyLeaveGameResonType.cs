namespace Game.Protocol.Communication
{
    /// <summary>
    /// 通知玩家離開遊戲的原因識別碼
    /// </summary>
    public enum NotifyLeaveGameResonType
    {
        /// <summary>
        /// 一般狀況的離開遊戲
        /// </summary>
        Normal = 1,

        /// <summary>
        /// 轉桌的離開遊戲
        /// </summary>
        ChangeTable = 2,
    }
}
