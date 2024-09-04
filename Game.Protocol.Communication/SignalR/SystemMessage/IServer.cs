namespace Game.Protocol.Communication.SignalR.SystemMessage
{
    /// <summary>
    /// Client: PNG
    /// Server: MemberMessageService
    /// 定義通用訊息之 Dto (數據傳輸物件)
    ///     - Server 要繼承並且實作
    ///     - 給 Client 呼叫用的 (利用繼承 IntelligentInterface<IServer>)
    /// </summary>
    public interface IServer : ICommon
    {
        /// <summary>
        /// 查詢啟用的系統公告
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Server_QueryEnableSystemMessages(string json);

        /// <summary>
        /// 系統公告已讀
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Server_ReadSystemMessage(string json);
        
        /// <summary>
        /// 查詢未讀的中獎影片回放
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Server_QueryUnReadAwardVideo(string json);

        /// <summary>
        /// 中獎影片回放已讀
        /// </summary>
        /// <param name="json"></param>
        void Server_ReadAwardVideo(string json);
    }
}
