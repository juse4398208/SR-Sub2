using System.Collections.Generic;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// DisplayInfo
    /// 遊戲桌顯示資訊
    /// </summary>
    public class NPCScenario
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public NPCScenario()
        {
            this.IsAccumulate = false;
            this.SpinRound = -1;
            this.SpinBet = new List<int>();
            this.SpinFrequence = 10000;
            this.IsWager = false;
            this.IsLeaderboard = false;
        }

        #region Property

        /// <summary>
        /// 是否累積彩金
        /// </summary>
        public bool IsAccumulate { get; set; }

        /// <summary>
        /// 入桌後 Spin 幾次 (-1 為無限Spin)
        /// </summary>
        public long SpinRound { get; set; }

        /// <summary>
        /// Spin 押注陣列 (對應下注表設定 index)
        /// </summary>
        public IList<int> SpinBet { get; set; }

        /// <summary>
        /// 多久 spin 一次 (毫秒)
        /// </summary>
        public int SpinFrequence { get; set; }

        /// <summary>
        /// 是否會寫注單
        /// </summary>
        public bool IsWager { get; set; }

        /// <summary>
        /// 是否能上排行榜
        /// </summary>
        public bool IsLeaderboard{ get; set; }

        #endregion Property
    }
}
