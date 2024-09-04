namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// CancelAwardResult
    /// </summary>
    public class CancelAwardResult
    {
        public long CancelSerial { get; set; }
        public int ResultCode { get; set; }
        public double CancelTime { get; set; }
    }
}