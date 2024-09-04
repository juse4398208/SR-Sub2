namespace Game.Protocol.Communication
{
    /// <summary>
    /// ServerJLogMessageCode
    /// Server的JLogMessageCode定義在此，Server是從100000000~199999999
    /// </summary>
    public class ServerJLogMessageCode
    {
        /// <summary>
        /// 注單資訊
        /// </summary>
        static public readonly int WagerInfo = 100000001;

        /// <summary>
        /// 點數異動資訊
        /// </summary>
        static public readonly int PointUpdateHistoryInfo = 100000002;

        /// <summary>
        /// 連線事件Error
        /// </summary>
        static public readonly int ConnectionStateError = 100000003;

        /// <summary>
        /// 連線事件Login
        /// </summary>
        static public readonly int ConnectionStateLogin = 100000004;

        /// <summary>
        /// 連線事件Logout
        /// </summary>
        static public readonly int ConnectionStateLogout = 100000005;

        /// <summary>
        /// 連線事件Resume
        /// </summary>
        static public readonly int ConnectionStateResume = 100000006;

        /// <summary>
        /// 連線事件WaitResumption
        /// </summary>
        static public readonly int ConnectionStateWaitResumption = 100000007;

        /// <summary>
        /// API會員扣點錯誤
        /// </summary>
        static public readonly int APIDeductPointError = 100000008;

        /// <summary>
        /// API會員扣點結果
        /// </summary>
        static public readonly int APIDeductPointResult = 100000009;

        /// <summary>
        /// API會員扣點逾時
        /// </summary>
        static public readonly int APIDeductPointTimeOut = 100000010;

        /// <summary>
        /// API會員扣點找不到Key
        /// </summary>
        static public readonly int APIDeductPointResultKeyNotFound = 100000011;

        /// <summary>
        /// 送出NPC入座命令時，沒有NPC可用
        /// </summary>
        static public readonly int NPCNotEnough = 100000012;

        /// <summary>
        /// RabbitMQ斷線
        /// </summary>
        static public readonly int RMQDisconnected = 100000013;

        /// <summary>
        /// Network送包過久，切斷連線
        /// </summary>
        static public readonly int NetworkCloseAsync = 100000014;

        /// <summary>
        /// ServerAP發生主迴圈延遲
        /// </summary>
        static public readonly int ExecuteTimeDelay = 100000015;

        /// <summary>
        /// ServerAP心跳
        /// </summary>
        static public readonly int ServerAPKeepAlive = 100000016;

        /// <summary>
        /// NLog寫入發生錯誤時
        /// </summary>
        static public readonly int NotifyNLogErrorInfo = 100000017;

        /// <summary>
        /// 網路底層建立監聽時，有例外狀況
        /// </summary>
        static public readonly int NetworkSocketListenFailed = 100000018;

        /// <summary>
        /// 更新資料表t_memberLobbyHistory失敗通知ACS重新寫入
        /// </summary>
        static public readonly int WriteMemberLobbyFailed = 100000019;

        /// <summary>
        /// 注單寫入CKDB失敗
        /// </summary>
        static public readonly int WriteWagerBackupFailed = 100000020;

        /// <summary>
        /// 子單寫入CKDB失敗
        /// </summary>
        static public readonly int WriteSubWagerBackupFailed = 100000021;

        /// <summary>
        /// 歷史注單寫入CKDB失敗
        /// </summary>
        static public readonly int WriteWagerHistoryBackupFailed = 100000022;

        /// <summary>
        /// GS 拉彩金失敗
        /// </summary>
        static public readonly int GSWinJPResultFailed = 100000023;

        /// <summary>
        /// GS 初始化彩金提示資訊失敗
        /// </summary>
        static public readonly int GSInitializeJPPromtInfoFailed = 100000024;

        /// <summary>
        /// 自動派彩找不到任何符合資格的NPC派獎
        /// </summary>
        static public readonly int AutoJackPotCannotFindAnyNPCToAward = 100000025;
    }
}
