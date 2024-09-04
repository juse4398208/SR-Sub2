namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// SetSystemAPInfo Response Data
    /// </summary>
    public sealed class SetSystemAPInfoResponseData
    {
        /// <summary>
        /// Gets or sets APID
        /// </summary>
        public int APID { get; set; }

        /// <summary>
        /// Gets or sets APName
        /// </summary>
        public string APName { get; set; }

        /// <summary>
        /// Gets or sets APType
        /// </summary>
        public string APType { get; set; }

        /// <summary>
        /// Gets or sets APState
        /// </summary>
        public int APState { get; set; }

        /// <summary>
        /// Gets or sets Result
        /// </summary>
        public int Result { get; set; }
    }
}
