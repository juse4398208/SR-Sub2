namespace Game.Protocol.Communication
{
    /// <summary>
    /// ServerMessageCode
    /// </summary>
    public enum ServerMessageCode
    {
        /// <summary>
        /// 失敗
        /// </summary>
        Fail = 0,

        /// <summary>
        /// 成功
        /// </summary>
        Success = 1,

        /// <summary>
        /// 被踢
        /// </summary>
        HasBeenKickedOut = 2,

        /// <summary>
        /// 維護中
        /// </summary>
        Maintaining = 3,

        /// <summary>
        /// 後踢前
        /// </summary>
        FollowingLoginKickedOut = 4,

        /// <summary>
        /// 禁能遊戲(會員遊戲被禁止)
        /// </summary>
        DenyGamesKickedOut = 5,

        /// <summary>
        /// 滿座
        /// </summary>
        FullSeated = 6,

        /// <summary>
        /// 已達加入遊戲上限
        /// </summary>
        ReachedMaximumOfPlayerGame = 7,

        /// <summary>
        /// 隨機挑選座位已滿
        /// </summary>
        RandomFullSeat = 8,

        /// <summary>
        /// 登入序號已使用過
        /// </summary>
        UsedLoginSerial = 9,

        /// <summary>
        /// 特定裝置踢離
        /// </summary>
        KickOutByPlatform = 10,

        /// <summary>
        /// 需要驗證
        /// </summary>
        Verification = 11,

        /// <summary>
        /// 單一遊戲維護
        /// </summary>
        GameMaintain = 12,

        /// <summary>
        /// 等待桌解散
        /// </summary>
        WaitTableDissolve = 13,

        /// <summary>
        /// 保留座錯誤
        /// </summary>
        ReserveSeatError = 14,

        /// <summary>
        /// 遊戲被後臺禁止
        /// </summary>
        AgentDenyGamesKickedOut = 15,

        /// <summary>
        /// 遊戲被後臺維護
        /// </summary>
        AgentGameMaintainKickedOut = 16,

        /// <summary>
        /// 被後臺踢出
        /// </summary>
        AgentKickedOut = 17,

        /// <summary>
        /// 轉桌失敗，尚未離開前桌
        /// </summary>
        ChangeTableFaileNotLeaveYet = 18,

        /// <summary>
        /// 轉桌失敗，已經離開前桌了
        /// </summary>
        ChangeTableFaileHaveLeave = 19,

        /// <summary>
        /// 轉桌失敗，隨機入桌時座位已滿
        /// </summary>
        ChangeTableRandomFullSeat = 20,

        /// <summary>
        /// 座位已滿且有保留座
        /// </summary>        
        SeatFullAndReserveSeat = 21,

        /// <summary>
        /// 排隊已關閉中
        /// </summary>
        LineUpClose = 22,

        /// <summary>
        /// 等待重連
        /// </summary>
        WaitResumption = 98,

        /// <summary>
        /// 已恢復
        /// </summary>
        Resume = 99,

        /// <summary>
        /// 斷線
        /// </summary>
        Disconnected = 100,

        /// <summary>
        /// 錯誤
        /// </summary>
        Error = 999,
    }
}
