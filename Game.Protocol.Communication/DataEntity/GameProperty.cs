namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Game 的屬性分類
    /// </summary>
    public class GameProperty
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public GameProperty()
        {
        }

        #region Property

        /// <summary>
        /// Gets or sets GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Gets or sets GameCategoryID, 目前只用於寫注單時給WEB分類用
        /// </summary>
        public int GameCategoryID { get; set; }

        #endregion Property
    }
}
