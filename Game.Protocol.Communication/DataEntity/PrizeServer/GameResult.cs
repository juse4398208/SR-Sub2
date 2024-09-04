using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// 遊戲結果
    /// </summary>
    public class GameResult
    {
        /// <summary>
        /// 遊戲編號
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// 幣別編號
        /// </summary>
        public List<int> CurrencyID { get; set; }

        /// <summary>
        /// 棋牌遊戲總贏分
        /// </summary>
        public long AllWinPoint { get; set; }
    }
}
