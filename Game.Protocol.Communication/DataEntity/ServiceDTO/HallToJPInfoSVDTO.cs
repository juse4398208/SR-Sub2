namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// HallToJPInfoSVDTO
    /// </summary>
    public class HallToJPInfoSVDTO
    {
        public int JPID { get; set; }

        public int HallID { get; set; }

        public int GameID { get; set; }

        public int JPCategoryID { get; set; }

        public int AccumulateRate { get; set; }
    }
}
