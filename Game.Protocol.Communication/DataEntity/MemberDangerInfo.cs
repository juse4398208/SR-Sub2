namespace Game.Protocol.Communication.DataEntity
{
    public class MemberDangerInfo
    {
        /// <summary>
        /// 會員編號
        /// </summary>
        public long MemberID { get; set; } = -1;

        /// <summary>
        /// 警示原因，警示群組ID
        /// </summary>
        public int DangerGroupID { get; set; }

        /// <summary>
        /// 是否為預設警示群組(後台的預設群組即為自動)   true: 自動, false: 手動
        /// </summary>
        public bool IsDefault { get; set; }
    }
}