using System.Collections.Generic;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// MemberLevelSettingSVDTO
    /// </summary>
    public class MemberLevelSettingSVDTO
    {
        /// <summary>
        /// 對應的是玩家等級
        /// </summary>
        public int MemberLevel { get; set; }

        /// <summary>
        /// 玩家能玩哪些廳
        /// </summary>
        public List<int> HallID { get; set; }

        /// <summary>
        /// 保留座時間
        /// </summary>
        public int HoldTime { get; set; }
    }
}
