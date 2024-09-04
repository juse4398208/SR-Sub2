namespace Game.Protocol.Communication
{
    /// <summary>
    /// 平台登入時的帳號類別
    /// </summary>
    public enum PlatformMemberType
    {  
        /// <summary>
        /// 一般帳號
        /// </summary>
        Normal = 1,

        /// <summary>
        /// 測試會員
        /// </summary>
        Test = 2,

        /// <summary>
        /// 試玩帳號
        /// </summary>
        Trial = 3,

        /// <summary>
        /// AI
        /// </summary>
        AI = 4,

        /// <summary>
        /// NPC
        /// </summary>
        NPC = 5
    }
}
