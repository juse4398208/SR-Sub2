namespace Game.Protocol.Communication.DataEntity
{
    using System;

    /// <summary>
    /// Fish Table Info
    /// </summary>
    public class FishTableInfo
    {
        /// <summary>
        /// Gets or sets PlayerFishTable
        /// </summary>
        public string PlayerFishTable { get; set; }

        /// <summary>
        /// Gets or sets TimeToRemove
        /// </summary>
        public DateTime TimeToRemove { get; set; }
    }
}
