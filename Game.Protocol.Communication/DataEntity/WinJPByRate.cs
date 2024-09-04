namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// WinJPByRate
    /// </summary>
    public class WinJPByRate
    {
        /// <summary>
        /// HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// JPCategory
        /// </summary>
        public int JPCategory { get; set; }

        /// <summary>
        /// WinJPRate
        /// </summary>
        public int WinJPRate { get; set; }

        /// <summary>
        /// ExchangeRate
        /// </summary>
        public int ExchangeRate { get; set; }
    }
}
