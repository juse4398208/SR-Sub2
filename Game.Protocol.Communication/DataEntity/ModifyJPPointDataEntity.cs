using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication
{
    public class ModifyJPPointDataEntity
    {
        /// <summary>
        /// JPID
        /// </summary>
        public int JPID { get; set; }

        /// <summary>
        /// JPPoint
        /// </summary>
        public long JPPoint { get; set; }
    }
}
