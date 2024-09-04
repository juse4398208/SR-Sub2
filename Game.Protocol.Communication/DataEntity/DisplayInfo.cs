namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// DisplayInfo
    /// 遊戲桌顯示資訊
    /// </summary>
    public class DisplayInfo
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public DisplayInfo()
        {
            this.Denom = 1.0;
            //this.TableInfo = new TableInfo();
        }

        #region Property

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableGroupID
        /// </summary>
        public int TableGroupID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// Denom
        /// </summary>
        public double Denom { get; set; }

        /// <summary>
        /// seatInfo
        /// </summary>
        //public TableInfo TableInfo { get; set; }

        /// <summary>
        /// DispalyInfo By GameLogic
        /// </summary>
        public string GLDisplayInfo { get; set; }

        /// <summary>
        /// 廳別
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// 桌顯示名稱
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 最低入桌LevelGroup
        /// </summary>
        public int MemberLevelGroupLimit { get; set; }

        #endregion Property
    }
}
