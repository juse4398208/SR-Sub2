using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication
{
    /// <summary>
    /// Redis轉移事件
    /// </summary>
    public enum RedisSwitchMasterEventType
    {
        /// <summary>
        /// 全部Redis轉移
        /// </summary>
        All = 0,

        /// <summary>
        /// EM Redis轉移
        /// </summary>
        EMRedis = 1,

        /// <summary>
        /// 共用 Redis轉移
        /// </summary>
        Common = 2,
    }
}
