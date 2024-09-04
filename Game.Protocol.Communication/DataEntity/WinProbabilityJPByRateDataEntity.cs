using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication
{
    public class WinProbabilityJPByRateDataEntity
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
        /// WinJPRate
        /// </summary>
        public int WinJPRate { get; set; }

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
