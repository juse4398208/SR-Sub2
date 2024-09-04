namespace Game.Protocol.Communication.DataEntity
{
    using System;

    public class ReserveSeatsInfo
    {
        /// <summary>
        /// Gets or sets MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Gets or sets HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// Gets or sets GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Gets or sets TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// Gets or sets TableName
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets MemberLevel
        /// </summary>
        public int MemberLevel { get; set; }

        /// <summary>
        /// Gets or sets StartTime
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets EndTime
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 保留座是否被暫停了
        /// </summary>
        public bool IsStop { get; set; } = false;

        /// <summary>
        /// 暫停的時間
        /// </summary>
        public DateTime StopTime { get; set; }
    }
}
