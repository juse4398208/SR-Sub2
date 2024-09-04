namespace Game.Protocol.Communication
{
    /// <summary>
    /// MESSAGE_PROTO_GTL_To_GL
    /// </summary>
    public enum MESSAGE_PROTO_GTL_To_GL
    {
        /// <summary>
        /// TestMsg 測試用訊息
        /// </summary>
        SEND_TEST_MESSAGE,

        /// <summary>
        /// SEND_KICK_MEMBER_INFO 發送踢除玩家
        /// </summary>
        SEND_KICK_MEMBER_INFO = 1,

        /// <summary>
        /// UPDATE_MEMBER_SETTING 更新會員設定
        /// </summary>
        UPDATE_MEMBER_SETTING = 2,

        /// <summary>
        /// 贏獎項
        /// </summary>
        SEND_WIN_AWARD = 3,

        /// <summary>
        /// 贏彩金
        /// </summary>
        SEND_WIN_JP = 4,

        /// <summary>
        /// Update module 更新機率模組
        /// </summary>
        UPDATE_MODULE = 5,

        /// <summary>
        /// NO_USE_6
        /// </summary>
        NO_USE_6 = 6,

        /// <summary>
        /// MODIFY_GAME_INFO 通知修改遊戲資訊
        /// </summary>
        MODIFY_GAME_INFO = 7,

        /// <summary>
        /// MODIFY_GAME_SUBRULE 通知修改遊戲設定
        /// </summary>
        MODIFY_GAME_SUBRULE = 8,

        /// <summary>
        /// SEND_TRIGGER GTL/GL自定義觸發行為
        /// </summary>
        SEND_TRIGGER = 9,

        /// <summary>
        /// SEND_CANCEL_AWARD GTL/GL 取消獎項
        /// </summary>
        SEND_CANCEL_AWARD = 10,

        /// <summary>
        /// SEND_CREDIT_CHANGE GTL/GL 通知會員點數改變
        /// </summary>
        SEND_CREDIT_CHANGE = 11,

        /// <summary>
        /// NO_USE_12
        /// </summary>
        NO_USE_12 = 12,

        /// <summary>
        /// Send GS Maintain 單一GS維護
        /// </summary>
        SEND_GS_MAINTAIN = 13,

        /// <summary>
        /// Send Member Deduct Point 通知會員扣點
        /// </summary>
        SEND_MEMBER_DEDUCT_POINT = 14,

        /// <summary>
        /// Send Clear Game Info 清除桌歷史紀錄
        /// </summary>
        SEND_CLEAR_GAME_INFO = 15,

        /// <summary>
        /// Send Kickback Limit 反水限制機率更新
        /// </summary>
        SEND_UPDATE_KICKBACK_LIMIT = 16,

        /// <summary>
        /// SEND_LUCKY_JP_MODULE_SETTING 更新幸運彩金模組資訊
        /// </summary>
        SEND_LUCKY_JP_MODULE_SETTING = 17,

        /// <summary>
        /// NO_USE_18
        /// </summary>
        NO_USE_18 = 18,

        /// <summary>
        /// NO_USE_19
        /// </summary>
        NO_USE_19 = 19,

        /// <summary>
        /// 強解GR命令
        /// </summary>
        SEND_FORCE_RELEASE_CARDGAME_GAMEROOM = 20,

        /// <summary>
        /// 單一桌維護
        /// </summary>
        SEND_TG_SINGLE_TABLE_MAINTAIN = 21,

        /// <summary>
        /// NO_USE_22
        /// </summary>
        NO_USE_22 = 22,

        /// <summary>
        /// 更新桌參數
        /// </summary>
        UPDATE_GAMETABLERULE = 23,

        /// <summary>
        /// 更新BigWin設定
        /// </summary>
        UPDATE_BIGWINSETTING = 24,

        /// <summary>
        /// 更新GameSetting 
        /// </summary>
        UPDATE_GAMESETTING = 25,

        /// <summary>
        /// 通知例外狀態還點
        /// </summary>
        NOTIFY_EXCEPTION_RETURN_POINT = 26,

        /// <summary>
        /// 更新 排行榜入榜條件設定
        /// </summary>
        UPDATE_RANKSETTINGS = 27,

        /// <summary>
        /// 更新TG遊戲下注區
        /// </summary>
        UPDATE_TG_GAMEBETFIELD = 28,

        /// <summary>
        /// 更新會員頭像和暱稱
        /// </summary>
        CHANGE_MEMBER_AVATAR = 29,

        /// <summary>
        /// 更新會員等級
        /// </summary>
        CHANGE_MEMBER_LEVEL = 30,
        
        /// <summary>
        /// 
        /// </summary>
        UPDATE_MEMBER_MODULE_SETTING = 31,

        /// <summary>
        /// 更新會員群組模組
        /// </summary>
        UPDATE_MEMBER_MODULE_GROUP_SETTING= 32,

        /// <summary>
        /// 
        /// </summary>
        NOTIFY_MEMBER_MODULE_GROUP_SETTING = 33,

        /// <summary>
        /// 更新TG櫻花下注設定
        /// </summary>
        UPDATE_TG_SAKURASETTING = 34,

        /// <summary>
        /// 更新警示帳號設定
        /// </summary>
        UPDATE_MEMBER_DANGER_ALERT_SETTING = 35,

        /// <summary>
        /// 更新TG自動背包設定
        /// </summary>
        UPDATE_TG_MEMBER_RESTRICT_EVENT = 36,

        /// <summary>
        /// 更新中獎紀錄設定
        /// </summary>
        UPDATE_AWARDLOWESTFILTER = 37,
    }
}
