using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity.Jlog
{
    public class DISRedisRefreshFail
    {
        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// PointType
        /// </summary>
        public int PointType { get; set; }
    }
}
