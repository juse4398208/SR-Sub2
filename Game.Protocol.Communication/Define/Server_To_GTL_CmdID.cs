namespace Game.Protocol.Communication
{
    public enum Server_To_GTL_CmdID
    {
        /// <summary>
        /// AS傳送給GTS的清除歷史資訊命令
        /// </summary>
        AS_TO_GTL_NOTIFY_CLEAR_GAME_INFO = 1001,

        /// <summary>
        /// AS傳送給GTS的強解棋牌遊戲遊戲室命令
        /// </summary>
        AS_TO_GTL_NOTIFY_FORCE_RELEASE_CARDGAME_GAMEROOM = 1002,

        /// <summary>
        /// 通知GTS 維護單一遊戲桌
        /// </summary>
        AS_TO_GTL_GAME_MAINTAIN_BY_TABLEID = 1003,

        /// <summary>
        /// NO_USE_2001
        /// </summary>
        NO_USE_2001 = 2001,

        /// <summary>
        /// NO_USE_2002
        /// </summary>
        NO_USE_2002 = 2002,

        /// <summary>
        /// NO_USE_2003
        /// </summary>
        NO_USE_2003 = 2003,

        /// <summary>
        /// WebToAS傳送給GTS 通知 取消派彩
        /// </summary>
        AS_TO_GTL_NOTIFY_CANCEL_AWARD = 2004,

        /// <summary>
        /// WebToAS傳送給GTS 更新 GameTableRule
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_GAMETABLERULE = 2005,

        /// <summary>
        /// NO_USE_2007
        /// </summary>
        NO_USE_2007 = 2007,

        /// <summary>
        /// 更新模組RTPLevel
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_MODULE_RTPLEVEL = 2008,

        /// <summary>
        /// 通知更新 BigWin 門檻設定
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_BIGWIN_SETTING = 2009,

        /// <summary>
        /// 通知更新 GameSetting
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_GAMESETTING = 2010,

        /// <summary>
        /// 通知更新換日
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_MACHINE_INFO = 2011,

        /// <summary>
        /// 通知TG桌參數
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_TG_TABLERULE = 2012,

        /// <summary>
        /// 通知TG遊戲限額
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_TG_BETLIMITS = 2013,

        /// <summary>
        /// 通知TG櫻花下注設定
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_TG_SAKURASETTING = 2014,

        /// <summary>
        /// 通知GL更新自動警示設定
        /// </summary>        
        AS_TO_GTL_NOTIFY_UPDATE_MEMBER_DANGER_ALERT_SETTING = 2015,

        /// <summary>
        /// 通知TG更新自動背包設定
        /// </summary>        
        AS_TO_GTL_NOTIFY_UPDATE_TG_MEMBER_RESTRICT_EVENT = 2016,
    }
}
