namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// JackpotSettingSVDTO
    /// </summary>
    public class JackpotSettingSVDTO
    {
        public int JPID { get; set; }

        public int GameID { get; set; }

        public int HallID { get; set; }

        public int JPCategoryID { get; set; }

        public long PointsBegin { get; set; }

        public long RecoverPoint { get; set; }

        public long MaxPoint { get; set; }

        public int AccumulateRate { get; set; }

        public long AutoAccumulateBetPoint { get; set; }

        public int AutoAccumulateFrequency {get;set;}

        public bool AutoAccumulateEnable { get; set; }
    }
}
