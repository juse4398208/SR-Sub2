namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// 遊戲桌顯示的Json
    /// </summary>
    public class JsonDisplayInfo
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public JsonDisplayInfo()
        {
            this.SeatInfo = new List<JsonSeatInfo>();
            this.Denom = 1.0;
            this.GameInfo = string.Empty;
        }

        /// <summary>
        /// gameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// 廳別
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// tableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// 桌顯示名稱
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Denom
        /// </summary>
        public double Denom { get; set; }

        /// <summary>
        /// SeatInfo
        /// </summary>
        public List<JsonSeatInfo> SeatInfo { get; set; }

        /// <summary>
        /// GameInfo
        /// </summary>
        public string GameInfo { get; set; }
    }
}
