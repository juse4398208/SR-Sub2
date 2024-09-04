using System;

namespace Game.Protocol.Communication.DataEntity
{
    public class LogTGBetFieldDaily
    {
        /// <summary>
        /// 帳務日(UTC+8)
        /// </summary>
        public DateTime DateBill { get; set; }

        /// <summary>
        /// 遊戲ID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// 遊戲桌ID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// 下注區ID
        /// </summary>
        public long BetFieldID { get; set; }

        /// <summary>
        /// 下注筆數
        /// </summary>
        public long WagerCount { get; set; }

        /// <summary>
        /// 洗碼量
        /// </summary>
        public long RollingPoint { get; set; }
    }
}