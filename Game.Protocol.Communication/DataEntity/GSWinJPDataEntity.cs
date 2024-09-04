using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication
{
    public class GSWinJPDataEntity
    {
        /// <summary>
        /// HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// JPCategory
        /// </summary>
        public int JPCategory { get; set; }

        /// <summary>
        /// ExchangeRate
        /// </summary>
        public int ExchangeRate { get; set; }

        /// <summary>
        /// WinJPPoint
        /// </summary>
        public long WinJPPoint { get; set; }

        /// <summary>
        /// WinJPDollars
        /// </summary>
        public long WinJPDollars { get; set; }

        /// <summary>
        /// BeforeJPPoint
        /// </summary>
        public long BeforeJPPoint { get; set; }

        /// <summary>
        /// AfterJPPoint
        /// </summary>
        public long AfterJPPoint { get; set; }

        /// <summary>
        /// ResponseJPPointList
        /// </summary>
        public List<Tuple<int, long, bool>> ResponseJPPointList { get; set; }

        /// <summary>
        /// WinJPResult
        /// </summary>
        public int WinJPResult { get; set; }
    }
}
