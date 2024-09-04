namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// PrizeInfo
    /// </summary>
    public class MemberRestrict
    {
        /// <summary>
        /// TotalMemberBags
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Points
        /// </summary>
        public long Points { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("(MemberID: {0}, Points: {1})", this.MemberID, this.Points);
        }
    }
}
