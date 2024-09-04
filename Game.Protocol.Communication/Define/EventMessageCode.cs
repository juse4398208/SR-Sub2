namespace Game.Protocol.Communication
{
    /// <summary>
    /// EventMessageCode
    /// </summary>
    public class EventMessageCode
    {
        /// <summary>
        /// ServerConntionError
        /// </summary>
        static public readonly int ServerConntionCode = 1;

        /// <summary>
        /// GamepointError
        /// 遊戲點數異常
        /// </summary>
        static public readonly int GamepointError = 2;

        /// <summary>
        /// APIDeductPointError
        /// API聊天室會員扣點錯誤
        /// </summary>
        static public readonly int NO_USE_3 = 3;

        /// <summary>
        /// APIDeductPointNotKey
        /// API聊天室會員扣點結果找不到Key
        /// </summary>
        static public readonly int NO_USE_4 = 4;

        /// <summary>
        /// DisplayServiceWarning
        /// 點數顯示服務警報
        /// </summary>
        static public readonly int DisplayServiceWarning = 5;

        /// <summary>
        /// SharkError
        /// 鯊皇異常
        /// </summary>
        static public readonly int NO_USE_6= 6;

        /// <summary>
        /// KickbackLimitError
        /// 反水限制設定異常
        /// </summary>
        static public readonly int NO_USE_7 = 7;

        /// <summary>
        /// TG桌連勝資訊儲存失敗
        /// </summary>
        static public readonly int NO_USE_8 = 8;

        /// <summary>
        /// 送出NPC入座命令時，沒有NPC可用
        /// </summary>
        static public readonly int NPCNotEnough = 9;

        /// <summary>
        /// RabbitMQ斷線
        /// </summary>
        static public readonly int RMQDisconnected = 10;

        /// <summary>
        /// 系統陪打寫單帳號資訊設定失敗
        /// </summary>
        static public readonly int NO_USE_11 = 11;

        /// <summary>
        /// Network送包過久，切斷連線
        /// </summary>
        static public readonly int NO_USE_12 = 12;

        /// <summary>
        /// AP主迴圈執行時間過久
        /// </summary>
        static public readonly int ExecuteTimeDelay = 13;

        /// <summary>
        /// AP心跳延遲
        /// </summary>
        static public readonly int APKeepAliveDelay = 14;

        /// <summary>
        /// NLog寫入時有問題通知
        /// </summary>
        static public readonly int NotifyNLogErrorInfo = 15;

        /// <summary>
        /// 遊戲清靴列表
        /// </summary>
        static public readonly int NO_USE_16 = 16;

        /// <summary>
        /// 遊戲清靴完成
        /// </summary>
        static public readonly int NO_USE_17 = 17;

        /// <summary>
        /// 網路底層建立監聽時，有例外狀況
        /// </summary>
        static public readonly int NetworkSocketListenFailed = 18;

        /// <summary>
        /// NO_USE_19
        /// </summary>
        public static readonly int NO_USE_19 = 19;

        /// <summary>
        /// 更新 MemerLobbyHistory 失敗
        /// </summary>
        static public readonly int NO_USE_20 = 20;

        /// <summary>
        /// 更新AP時間/是否異常
        /// </summary>
        static public readonly int UpdateAPMonitorStatus = 21;

        /// <summary>
        /// 注單寫入 CKDB 失敗
        /// </summary>
        static public readonly int WriteWagerBackupFailed = 22;

        /// <summary>
        /// 子單寫入 CKDB 失敗
        /// </summary>
        static public readonly int WriteSubWagerBackupFailed = 23;

        /// <summary>
        /// 歷史注單寫入 CKDB 失敗
        /// </summary>
        static public readonly int WriteWagerHistoryBackupFailed = 24;

        /// <summary>
        /// 派彩逾時，後續會call WebAPI取消派彩
        /// </summary>
        static public readonly int AwardTimeout = 25;

        /// <summary>
        /// AP 斷線
        /// </summary>
        static public readonly int APDisconnection = 26;

        /// <summary>
        /// 是否禁止轉帳
        /// </summary>
        static public readonly int TransferState = 27;

        /// <summary>
        /// 彩金相關功能發生問題
        /// </summary>
        static public readonly int JPError = 28;
        
        /// <summary>
        /// 通知刷新顯示服務
        /// </summary>
        static public readonly int DISRefresh = 29;

        /// <summary>
        /// 自動派彩找不到符合資格的NPC去派獎
        /// </summary>
        static public readonly int AutoJackPotCannotFindNPCToAward = 30;

        /// <summary>
        /// GameTableInfoService 讀取桌資訊失敗
        /// </summary>
        static public readonly int ReloadGameTableInfoFailed = 31;

        /// <summary>
        /// AutoJackPotService NPC派彩失敗
        /// </summary>
        static public readonly int AutoJackPotNPCAwardFail = 32;

        /// <summary>
        /// 遊戲通用告警訊息
        /// </summary>
        static public readonly int GameCommonAlert = 33;
    }
}
