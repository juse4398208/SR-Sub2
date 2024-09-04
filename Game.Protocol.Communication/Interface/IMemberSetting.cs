namespace Game.Protocol.Communication
{
    using System.Collections.Generic;

    /// <summary>
    /// Member setting
    /// </summary>
    public interface IMemberSetting
    {
        #region Property

        /// <summary>
        /// Get or sets DenyKickBackGameList
        /// </summary>
        List<int> DenyKickBackGameList { get; }

        /// <summary>
        /// Get DenyGameList
        /// </summary>
        List<int> DenyGameList { get; }

        #endregion Property
    }
}
