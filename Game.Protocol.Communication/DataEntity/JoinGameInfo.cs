namespace Game.Protocol.Communication.DataEntity
{

    /// <summary>
    /// JoinGameInfo
    /// </summary>
    public class JoinGameInfo
    {
        /// <summary>
        /// GameSerial
        /// </summary>
        public string GameSerial { get; set; }

        /// <summary>
        /// GSAPID
        /// </summary>
        public int GSAPID { get; set; }

        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// MemberCloneID
        /// </summary>
        public int MemberCloneID { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// ExchangeRate
        /// </summary>
        public int ExchangeRate { get; set; }

        /// <summary>
        /// Gets NPCScript
        /// 取得 NPC腳本
        /// </summary>
        public string NPCScript { get; set; }

        /// <summary>
        /// NickName
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Channel ID.
        /// </summary>
        public int ChannelID { get; set; }

        /// <summary>
        /// UserInfo
        /// </summary>
        public string UserInfo { get; set; }

        /// <summary>
        /// Result
        /// </summary>
        public int Result { get; set; }

        /// <summary>
        /// AgentType
        /// </summary>
        public int MemberTypeID { get; set; }

        /// <summary>
        /// 玩家等級 (投注會升級的那種)
        /// </summary>
        public int MemberLevel { get; set; }
    }
}
