namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// ForceWinAward
    /// </summary>
    public class ForceWinJP
    {
        /// <summary>
        /// PointType
        /// </summary>
        public int PointType { get; set; }

        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// AwardID
        /// </summary>
        public int AwardID { get; set; }

        /// <summary>
        /// AwardLogID
        /// </summary>
        public string AwardLogID { get; set; }

        /// <summary>
        /// MiniRate
        /// </summary>
        public long MiniRate { get; set; }

        /// <summary>
        /// MaxRate
        /// </summary>
        public long MaxRate { get; set; }

        /// <summary>
        /// IsNPC
        /// </summary>
        public bool IsNPC { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// awardJPPoint
        /// </summary>
        public long AwardJPPoint { get; set; }

        /// <summary>
        /// isUseRate
        /// </summary>
        public bool IsUseRate { get; set; }

        /// <summary>
        /// FgType
        /// </summary>
        public int FgType { get; set; }

        /// <summary>
        /// NickName
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// LastBetPoint
        /// </summary>
        public long LastBetPoint { get; set; }

        /// <summary>
        /// MaxBetPoint
        /// </summary>
        public long MaxBetPoint { get; set; }

        /// <summary>
        /// MinBetPoint
        /// </summary>
        public long MinBetPoint { get; set; }

        /// <summary>
        /// avgBetPoint
        /// </summary>
        public long AvgBetPoint { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// MemberGroupID
        /// </summary>
        public int MemberGroupID { get; set; }

        // Mongo DocumentID
        public string WorkAccountID { get; set; }

        // DetailID (GUID)
        public string WorkAccountDetailID { get; set; }

        /// <summary>
        /// 發放時最低下注額度
        /// </summary>
        public long BetPointMini { get; set; }

        /// <summary>
        /// 發放的會員類型
        /// </summary>
        public int MemberTypeID { get; set; }
    }
}
