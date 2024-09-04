namespace Game.Protocol.Communication.DataEntity
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ActivityNotificationData
    /// </summary>
    public class ActivityNotificationData
    {
        /// <summary>
        /// ActivitySerial
        /// </summary>
        public long ActivitySerial { get; set; }

        /// <summary>
        /// DateStart
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// DateEnd
        /// </summary>
        public DateTime DateEnd { get; set; }

        /// <summary>
        /// PrizeInfo
        /// </summary>
        public PrizeInfo PrizeInfo { get; set; }

        /// <summary>
        /// restraint
        /// </summary>
        public List<Restraint> Restraint { get; set; }

        /// <summary>
        /// Members
        /// </summary>
        public List<int> Members { get; set; }

        /// <summary>
        /// MemberRestrict
        /// </summary>
        public List<MemberRestrict> MemberRestrict { get; set; }
    }
}
