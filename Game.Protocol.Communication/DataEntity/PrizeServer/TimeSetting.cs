namespace Game.Protocol.Communication.DataEntity
{
    using System;

    public class TimeSetting
    {
        /// <summary>
        /// 區間時間(Min)
        /// </summary>
        public string TimeRangeStart { get; set; }

        /// <summary>
        /// 區間時間(Max)
        /// </summary>
        public string TimeRangeEnd { get; set; }

        /// <summary>
        /// 派獎次數
        /// </summary>
        public int AwardCount { get; set; }

        /// <summary>
        /// 派彩間隔時間(分)
        /// </summary>
        public int IntervalTime { get; set; }
    }
}
