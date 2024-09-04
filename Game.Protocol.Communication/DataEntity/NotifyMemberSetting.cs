namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Notify Member setting
    /// </summary>
    public class NotifyMemberSetting
    {
        /// <summary>
        /// NotifyMemberSetting
        /// </summary>
        public NotifyMemberSetting()
        {
            this.EnableKickBack = false;
        }

        #region Property

        /// <summary>
        /// Get or sets MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// Get or sets MemberCloneID
        /// </summary>
        public int MemberCloneID { get; set; }

        /// <summary>
        /// Get or sets EnableKickBack
        /// </summary>
        public bool EnableKickBack { get; set; }

        #endregion Property

        #region Method
        #endregion Method
    }
}
