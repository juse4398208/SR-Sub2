using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication
{
    public class AccumulateProbabilityJPDataEntity
    {
        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// ExchangeRate
        /// </summary>
        public int ExchangeRate { get; set; }

        /// <summary>
        /// BetPoint
        /// </summary>
        public long BetPoint { get; set; }
    }
}
