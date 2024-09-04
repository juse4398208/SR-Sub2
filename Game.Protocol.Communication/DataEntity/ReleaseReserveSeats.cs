namespace Game.Protocol.Communication.DataEntity
{
    public class ReleaseReserveSeats
    {
        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }
        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }
        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }
        /// <summary>
        /// 釋放保留座
        /// </summary>
        public bool ReleaseSeats { get; set; }

    }
}
