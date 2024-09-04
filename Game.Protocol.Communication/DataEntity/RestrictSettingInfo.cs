namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// KickBack Info
    /// </summary>
    public class RestrictSettingInfo
    {
        #region Property

        public int ResultCode { get; set; }

        /// <summary>
        /// Gets or sets TypeID
        /// </summary>
        public bool IsEnable { get; set; }

        #endregion Property
    }
}
