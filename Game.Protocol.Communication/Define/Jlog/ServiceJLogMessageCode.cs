namespace Game.Protocol.Communication
{
    /// <summary>
    /// ServiceJLogMessageCode
    /// Service的JLogMessageCode定義在此，Service是從300000000~399999999
    /// </summary>
    public class ServiceJLogMessageCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        static public readonly int Success = 300000000;

        /// <summary>
        /// 不需特別處理的錯誤
        /// </summary>
        static public readonly int Error = 399999999;

        /// <summary>
        /// RabbitMQ斷線
        /// </summary>
        static public readonly int RMQDisconnected = 300000001;

        /// <summary>
        /// AP 斷線
        /// </summary>
        static public readonly int APDisconnection = 300000002;        
        
        /// <summary>
        /// DIS 更新Redis失敗
        /// </summary>
        static public readonly int DISRedisUpdateFail = 300000003;        
        
        /// <summary>
        /// DIS 取得會員點數失敗
        /// </summary>
        static public readonly int DISSelectPointFail = 300000004;

        /// <summary>
        /// GameTableInfoService 讀取桌資訊失敗
        /// </summary>
        static public readonly int ReloadGameTableInfoFailed = 300000005;

        /// <summary>
        /// AutoJackPotService NPC 派彩失敗
        /// </summary>
        static public readonly int NPCAwardFail = 300000006;
    }
}
