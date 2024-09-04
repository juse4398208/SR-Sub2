namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// KickMemberInfoList
    /// </summary>
    public class KickMemberInfoList
    {
        public KickMemberInfoList()
        {
            this.list = new List<KickMemberInfo>();
        }

        /// <summary>
        /// list
        /// </summary>
        public List<KickMemberInfo> list { get; set; }
    }
}
