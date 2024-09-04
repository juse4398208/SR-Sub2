namespace Game.Protocol.Communication
{
    /// <summary>
    /// GameJLogMessageCode
    /// Game的JLogMessageCode定義在此，Game是從200000000~299999999
    /// </summary>
    public class GameJLogMessageCode
    {
        /// <summary>
        /// 點數異常
        /// </summary>
        static public readonly int GamePointError = 200000001;

        /// <summary>
        /// 鯊皇異常(NO_USE)
        /// </summary>
        static public readonly int SharkError= 200000002;

        /// <summary>
        /// 反水限制設定異常(NO_USE)
        /// </summary>
        static public readonly int KickbackLimitError = 200000003;

        /// <summary>
        /// TG連勝資訊異常(NO_USE)
        /// </summary>
        static public readonly int TGWinCountError = 200000004;

        /// <summary>
        /// 陪打寫單帳號資訊設定失敗(NO_USE)
        /// </summary>
        static public readonly int SystemBotSettingInfoFail = 200000005;

        /// <summary>
        /// 遊戲清靴清單(NO_USE)
        /// </summary>
        static public readonly int ClearGameList = 200000006;

        /// <summary>
        /// 遊戲清靴完成(NO_USE)
        /// </summary>
        static public readonly int ClearGameCompleted = 200000007;

        /// <summary>
        /// 取得自動背包門檻失敗(NO_USE)
        /// </summary>
        static public readonly int NO_USE_200000008 = 200000008;

        /// <summary>
        /// 派彩逾時
        /// </summary>
        static public readonly int AwardTimeout = 200000009;

        /// <summary>
        /// 通知轉點狀態
        /// </summary>
        static public readonly int TransferState = 200000010;

        /// <summary>
        /// 遊戲共用告警訊息
        /// </summary>
        static public readonly int GameCommonAlert = 299999999;
    }
}
