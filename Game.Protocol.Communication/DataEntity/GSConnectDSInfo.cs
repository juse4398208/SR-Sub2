namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// GSConnectDSInfo
    /// </summary>
    public class GSConnectDSInfo
    {
        /// <summary>
        /// DSConfigName
        /// </summary>
        public List<string> DSConfigName { get; set; }

        /// <summary>
        /// WriteWager
        /// </summary>
        public string WriteWager { get; set; }

        /// <summary>
        /// WriteSubWager
        /// </summary>
        public string WriteSubWager { get; set; }

        /// <summary>
        /// WrtiePointChange
        /// </summary>
        public string WrtiePointChange { get; set; }
    }
}
