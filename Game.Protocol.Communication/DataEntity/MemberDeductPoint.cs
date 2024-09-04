namespace Game.Protocol.Communication.DataEntity
{
    public class MemberDeductPoint
    {
        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// PointType
        /// </summary>
        public int PointType { get; set; }

        /// <summary>
        /// DeductPoint
        /// </summary>
        public long DeductPoint { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public int Type { get; set; }
    }
}
