using System;

namespace Game.Protocol.Communication.DataEntity
{
    public class LogCGAnteDaily
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
        /// 底注
        /// </summary>
        public long Ante { get; set; }
    
        /// <summary>
        /// 會員ID
        /// </summary>
        public long MemberID { get; set; }
    
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