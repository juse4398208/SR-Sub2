namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// PlayerInfo
    /// </summary>
    public class PlayerInfo
    {
        #region Property

        /// <summary>
        /// Gets or sets GameSerial
        /// 取得或設定 遊戲序號
        /// </summary>
        public string GameSerial { get; set; }

        /// <summary>
        /// Gets or sets MemberID
        /// 取得或設定 會員識別號
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Gets or sets MemberCloneID
        /// 取得或設定 會員分身識別號
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
        /// 廳號
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// TableGroupID
        /// </summary>
        public int TableGroupID { get; set; }

        /// <summary>
        /// Gets or sets Account
        /// 取得或設定 會員帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets ExchangeRate
        /// 取得或設定 匯率
        /// </summary>
        public int ExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets NPCScript
        /// 取得或設定 NPC腳本
        /// </summary>
        public string NPCScript { get; set; }

        /// <summary>
        /// Gets or sets NickName
        /// 取得或設定 會員暱稱
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// MemberTypeID
        /// </summary>
        public int MemberTypeID { get; set; }

        /// <summary>
        /// ChannelID
        /// </summary>
        public int ChannelID { get; set; }

        /// <summary>
        /// UserInfo
        /// </summary>
        public string UserInfo { get; set; }

        /// <summary>
        /// MemberLevel
        /// </summary>
        public int MemberLevel { get; set; }

        /// <summary>
        /// MemberLevelGroup
        /// </summary>
        public int MemberLevelGroupID { get; set; }

        /// <summary>
        /// 從哪個PNG連進來
        /// </summary>
        public int PNGAPID { get; set; }

        /// <summary>
        /// 從哪個RS連進來
        /// </summary>
        public string RSUID { get; set; }

        /// <summary>
        /// 會員的連線序號
        /// </summary>
        public string UserConnectUID { get; set; }

        /// <summary>
        /// 平台的MemberID
        /// </summary>
        public long SrcMemberID { get; set; }

        /// <summary>
        /// 單局上限
        /// </summary>
        public long MaxCarryPoint { get; set; }
        #endregion Property
    }
}
