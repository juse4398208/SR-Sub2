namespace Game.Protocol.Communication
{
    public enum ScheduleTimeType
    {
        /// <summary>
        /// Cron 表示式
        /// </summary>
        Cron = 0,

        /// <summary>
        /// 排程間隔。單位秒
        /// </summary>
        Interval = 1,

        /// <summary>
        /// 一次性作業。單位秒
        /// </summary>
        Disposables = 2,


    }
}