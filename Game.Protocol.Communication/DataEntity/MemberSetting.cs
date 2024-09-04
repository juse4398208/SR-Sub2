namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Member setting
    /// </summary>
    public class MemberSetting : IMemberSetting
    {
        /// <summary>
        /// MemberSetting
        /// </summary>
        public MemberSetting()
        {
            this.DenyKickBackGameList = new List<int>();
            this.DenyGameList = new List<int>();
        }

        #region Property

        /// <summary>
        /// Get or sets DenyKickBackGameList
        /// </summary>
        public List<int> DenyKickBackGameList { get; set; }

        /// <summary>
        /// Get or sets DenyGameList
        /// </summary>
        public List<int> DenyGameList { get; set; }

        #endregion Property

        #region Method

        /// <summary>
        /// Override ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        #endregion Method
    }
}
