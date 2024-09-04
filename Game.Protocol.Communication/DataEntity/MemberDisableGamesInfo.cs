using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberDisableGamesInfo
    {
        /// <summary>
        /// 會員ID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// 禁用遊戲清單
        /// </summary>
        public List<int> DisableGameIDs { get; set; }
    }
}