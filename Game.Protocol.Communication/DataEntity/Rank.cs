namespace Game.Protocol.Communication.DataEntity
{
    public class Rank
    {
        /// <summary>
        /// 排行榜的類別
        /// </summary>
        public RankType? TypeID { get; set; }

        public MemberType? MemberTypeID { get; set; }

        public long? SrcMemberID { get; set; }

        public long? MemberID { get; set; }

        ///點數
        public long? MaxWinPoint { get; set; }

        ///倍率
        public long? MaxMultiple { get; set; }

        /// <summary>
        /// DateWager - yyyy/MM/dd hh24:mi:ss
        /// </summary>
        public string DateWager { get; set; }

        public string WagerSerial { get; set; }

        public string TableName { get; set; }

        public int? GameID { get; set; }
        
        /// <summary>
        /// 下注點數
        /// </summary>
        public long BetPoint { get; set; }
    }
}