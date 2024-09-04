namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// UpdateMemberInfoList
    /// </summary>
    public class UpdateMemberInfoList
    {
        public UpdateMemberInfoList()
        {
            this.list = new List<UpdateMemberInfo>();
        }

        /// <summary>
        /// list
        /// </summary>
        public List<UpdateMemberInfo> list { get; set; }
    }
}
