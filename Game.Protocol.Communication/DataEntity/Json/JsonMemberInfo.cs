namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// 會員資料的Json
    /// </summary>
    public class JsonMemberInfo
    {
        /// <summary>
        /// memberId
        /// </summary>
        public long MemberId;

        /// <summary>
        /// gameSerial
        /// </summary>
        public string GameSerial;

        /// <summary>
        /// 座位狀態
        /// </summary>
        public SeatState SeatState;

        /// <summary>
        /// 座位玩家類型
        /// </summary>
        public int MemberType;

        /// <summary>
        /// 玩家裝置
        /// </summary>
        public int DeviceType;

        /// <summary>
        /// MemberLevel
        /// </summary>
        public int MemberLevel { get; set; }
    }
}
