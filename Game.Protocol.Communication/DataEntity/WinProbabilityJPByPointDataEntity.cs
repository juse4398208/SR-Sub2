using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication
{
    public class WinProbabilityJPByPointDataEntity
    {
        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// JPCategory
        /// </summary>
        public int JPCategory { get; set; }

        /// <summary>
        /// WinJPPoint
        /// </summary>
        public long WinJPPoint { get; set; }

        /// <summary>
        /// ExchangeRate
        /// </summary>
        public int ExchangeRate { get; set; }

        /// <summary>
        /// RequestJPPointList
        /// </summary>
        public List<int> RequestJPPointList { get; set; }
    }
}
