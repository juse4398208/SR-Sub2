using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// MemberPointKeyCode
    /// </summary>
    public enum MemberPointKeyCode
    {
        /// <summary>
        /// DBPoint
        /// </summary>
        DBPoint = 0,

        /// <summary>
        /// GamePoint
        /// </summary>
        GamePoint = 1,

        /// <summary>
        /// TotalPoint
        /// </summary>
        TotalPoint = 2,

        /// <summary>
        /// PhasePoint
        /// </summary>
        PhasePoint = 3,

        /// <summary>
        /// PhaseAllPoint
        /// </summary>
        PhaseAllPoint = 4,

        /// <summary>
        /// IsPointLock
        /// </summary>
        IsPointLock = 5,
    }
}
