using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// MemberGameHistory
    /// </summary>
    public class MemberGameHistory
    {
        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// GameSerial
        /// </summary>
        public string GameSerial { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// GameState
        /// </summary>
        public int GameState { get; set; }

        /// <summary>
        /// UpdateDateTime
        /// </summary>
        public double UpdateDateTime { get; set; }

        /// <summary>
        /// GSAPID
        /// </summary>
        public int GSAPID { get; set; }
    }
}
