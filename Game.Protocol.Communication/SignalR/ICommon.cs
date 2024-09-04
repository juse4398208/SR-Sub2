namespace Game.Protocol.Communication.SignalR
{
    public interface ICommon
    {
        /// <summary>
        /// 跟 Server端註冊
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Server_RegistClient(CommonDto.RegistClientDto dto);

        /// <summary>
        /// 跟 Server端解註冊
        /// </summary>
        /// <param name="json">參考 SystemMessageDto 與 function 同名之類別</param>
        void Server_UnRegistClient(CommonDto.UnRegistClientDto dto);
    }
}
