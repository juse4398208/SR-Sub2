namespace Game.Protocol.Communication.DataEntity
{

    public class ScheduleSetting
    {
        public string ScheduleJobName { get; set; }

        public ScheduleTimeType ScheduleTimeType { get; set; }

        public bool IsAllowConcurrentExecution { get; set; }

        public string TimeSetting { get; set; }

        public bool IsEnable { get; set; }
    }
}