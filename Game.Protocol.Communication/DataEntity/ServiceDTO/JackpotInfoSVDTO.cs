namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// JackpotInfoSVDTO
    /// </summary>
    public class JackpotInfoSVDTO
    {
        public int JPID { get; set; }

        public long JPPoint { get; set; }

        public long PointsBegin { get; set; }

        public long RecoverPoint { get; set; }

        public long MaxPoint { get; set; }
    }
}
