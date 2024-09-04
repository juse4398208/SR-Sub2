using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Web 使用 Sapi Capi都需繼承這個
    /// </summary>
    public class WebMiddlewareBase
    {
        /// <summary>
        /// CallTime
        /// </summary>
        public DateTime CallTime { get; set; } = DateTime.Now;

    }
}
