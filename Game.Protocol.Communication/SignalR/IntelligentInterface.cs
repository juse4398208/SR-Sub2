namespace Game.Protocol.Communication.SignalR
{
    /// <summary>
    /// 傳入 T (IServer or IClient) 讓 IDE Intelligent 能叫出 function
    /// 目前是讓 Client端使用
    /// 因 Server 端已有 Hub<T> 可以呼叫 Clients.Caller.T function
    /// </summary>
    public abstract class IntelligentInterface<T>
    {
        public T Server { get; }
    }
}
