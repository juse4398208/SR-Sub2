namespace Game.Protocol.Communication.DataEntity
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ReserveSeatsInfoByMember
    /// </summary>
    public class ReserveSeatsInfoByMember
    {
        /// <summary>
        /// Gets or sets MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// ReserveSeatsInfos
        /// </summary>
        public List<ReserveSeatsInfo> ReserveSeatsInfos { get; set; }
    }
}
