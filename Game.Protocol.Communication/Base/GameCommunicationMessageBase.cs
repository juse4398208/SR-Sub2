namespace Game.Protocol.Communication
{
    using System;

    /// <summary>
    /// GameCommunicationMessageBase
    /// GTL 與 GL 溝通訊息的JSON Base
    /// </summary>
    public class GameCommunicationMessageBase
    {
        /// <summary>
        /// 訊息命令
        /// </summary>
        public Enum HandleCommand { get; set; }
    }
}
