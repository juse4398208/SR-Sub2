namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// SetSystemAPInfo Request Data
    /// </summary>
    public sealed class SetSystemAPInfoRequestData
    {
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
    }
}
