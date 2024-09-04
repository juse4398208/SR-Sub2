namespace Game.Protocol.Communication.DataEntity
{
    public class MemberCategoryStillWinDayInfo
    {
        /// <summary>
        /// 遊戲分類
        /// </summary>
        public int GameCategoryID { get; set; }

        /// <summary>
        /// 連輸連贏天數
        /// </summary>
        public int StillWinDay { get; set; }
    }
}