namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// request Data
    /// </summary>
    public class RestrictSettingRequestDataInfo
    {
        /// <summary>
        /// Gets or sets Game ID
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// Gets or sets MerchantID
        /// </summary>
        public long MemberID { get; set; }
    }
}
