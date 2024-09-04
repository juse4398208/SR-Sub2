namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// AutoAccumulateJPSettingSVDTO
    /// </summary>
    public class AutoAccumulateJPSettingSVDTO
    {
        public int JPID { get; set; }

        public int AccumulateRate { get; set; }

        public long BetPoint { get; set; }

        public int Frequency { get; set; }

        public bool Enabled { get; set; }
    }
}
