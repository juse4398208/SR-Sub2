namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// 遊戲桌顯示的Json
    /// </summary>
    public class JsonMachineInfo
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public JsonMachineInfo()
        {
            this.SeatInfo = new List<JsonMemberInfo>();
            this.Denom = 1.0;
            this.ProbInfo = string.Empty;
            this.GameInfo = string.Empty;
        }

        /// <summary>
        /// gameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// tableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// Denom
        /// </summary>
        public double Denom { get; set; }

        /// <summary>
        /// SeatInfo
        /// </summary>
        public List<JsonMemberInfo> SeatInfo { get; set; }

        /// <summary>
        /// ProbInfo
        /// </summary>
        public string ProbInfo { get; set; }

        /// <summary>
        /// GameInfo
        /// </summary>
        public string GameInfo { get; set; }
    }
}
