using System;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberGameRecordInfo
    {
        /// <summary>
        /// 遊戲內容(建議長度小於 1MB)
        /// </summary>
        public string Content { get; set; }
    }
}