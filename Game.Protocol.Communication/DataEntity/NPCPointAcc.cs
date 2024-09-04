using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class NPCPointAcc
    {
        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// 累積投注(萬分位)
        /// </summary>
        public long PointAcc { get; set; }

        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime DateUpdate { get; set; }
    }
}
