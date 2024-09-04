namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// ForceWinAward
    /// </summary>
    public class ForceWinAward
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
        /// IsNPC
        /// </summary>
        public bool IsNPC { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        public string Account { get; set; }

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

        // Mongo DocumentID
        public string WorkAccountID { get; set; }

        // DetailID (GUID)
        public string WorkAccountDetailID { get; set; }
    }
}
