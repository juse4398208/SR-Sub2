namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// WordCollection Response Data
    /// </summary>
    public sealed class WordCollectionRequestDataInfo
    {
        /// <summary>
        /// Gets or sets Member ID
        /// </summary>
        public long memberID { get; set; }

        /// <summary>
        /// Gets or sets Game ID
        /// </summary>
        public int gameID { get; set; }

        /// <summary>
        /// Gets or sets Collection
        /// </summary>
        public string collection { get; set; }
    }
}
