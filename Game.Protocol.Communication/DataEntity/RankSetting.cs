using System;

namespace Game.Protocol.Communication.DataEntity
{
    public class RankSetting
    {
        // 排行榜類型
        public RankType RankType { get; set; }

        /// <summary>
        /// 入榜門檻(點數無萬分位)
        /// </summary>
        public long Condition { get; set; }
    }
}