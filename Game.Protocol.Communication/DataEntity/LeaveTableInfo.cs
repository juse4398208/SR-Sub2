namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// LeaveTableInfo
    /// 要求遊戲解散
    /// </summary>
    public class LeaveTableInfo
    {
        #region Property

        /// <summary>
        /// memberID
        /// </summary>
        public long memberID { get; set; }

        /// <summary>
        /// memberCloneID
        /// </summary>
        public int memberCloneID { get; set; }

        /// <summary>
        /// gameSerial
        /// </summary>
        public string gameSerial { get; set; }

        /// <summary>
        /// isNPC
        /// </summary>
        public int isNPC { get; set; }

        #endregion Property
    }
}
