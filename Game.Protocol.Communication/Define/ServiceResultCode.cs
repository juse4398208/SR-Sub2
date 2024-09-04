namespace Game.Protocol.Communication
{
    /// <summary>
    /// Service Result Code Enum
    /// </summary>
    public enum ServiceResultCode
    {
        /// <summary>
        /// Represents Default
        /// </summary>
        Default = 0,

        /// <summary>
        /// Represents Success
        /// </summary>
        Success = 1,

        /// <summary>
        /// Represents NoData
        /// </summary>
        NoData = 2,

        /// <summary>
        /// Represents TimeOut
        /// </summary>
        TimeOut = 3,

        /// <summary>
        /// Represents Error
        /// </summary>
        Error = 4,

        /// <summary>
        /// Represents NotFoundUri
        /// </summary>
        NotFoundUri = 5,

        /// <summary>
        /// Represents LockPoint
        /// </summary>
        LockPoint = 9999,
    }
}
