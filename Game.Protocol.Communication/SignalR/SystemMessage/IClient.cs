namespace Game.Protocol.Communication.SignalR.SystemMessage
{
    /// <summary>
    /// Client: PNG
    /// Server: MemberMessageService
    /// 定義通用訊息之 Dto (數據傳輸物件)
    ///     - Client 要繼承並且實作
    ///     - 給 Server 呼叫用的 (利用繼承 Hub<IClient>)
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// 發送系統公告
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Client_ResponseSystemMessage(string json);

        /// <summary>
        /// 系統公告取消
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Client_SystemMessageDisable(string json);

        /// <summary>
        /// 啟用系統公告
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Client_SystemMessageEnable(string json);
    }
}
