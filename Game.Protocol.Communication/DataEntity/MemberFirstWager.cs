using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberFirstWager
    {
        /// <summary>
        /// MemberID會員編號
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// GameCategoryID
        /// </summary>
        public int GameCategoryID { get; set; }

        /// <summary>
        /// 首單時間
        /// </summary>
        public DateTime? FirstWagerTime { get; set; }
    }
}
