namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Restrict Setting Response Data
    /// </summary>
    public sealed class RestrictSettingResponseData
    {
        /// <summary>
        /// Gets or sets ResultCode
        /// </summary>
        public int ResultCode { get; set; }

        /// <summary>
        /// Gets or sets ResponseData
        /// </summary>
        public string ResponseData { get; set; }

        /// <summary>
        /// Gets or sets GameData
        /// </summary>
        public string GameData { get; set; }
    }
}
