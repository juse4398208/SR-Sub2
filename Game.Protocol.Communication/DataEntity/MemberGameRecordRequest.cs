using System;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberGameRecordRequest
    {
        /// <summary>
        /// 會員編號
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// 遊戲ID
        /// </summary>
        public int GameID { get; set; }
        
        /// <summary>
        /// 桌號
        /// </summary>
        public int TableID { get; set; }
        
        /// <summary>
        /// 遊戲內容(建議長度小於 1MB)
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 更新時間 TTL:永久
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}