namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// DisplayInfo
    /// 遊戲桌顯示資訊
    /// </summary>
    public class ModifyGameInfo
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public ModifyGameInfo()
        {
            this.GameInfo = string.Empty;
            this.ModifyItem = string.Empty;
        }

        #region Property

        /// <summary>
        /// Gets or sets GameInfo 遊戲資訊
        /// </summary>
        public string GameInfo { get; set; }

        /// <summary>
        /// Gets or sets ModifyItem 修改項目
        /// </summary>
        public string ModifyItem { get; set; }

        #endregion Property
    }
}
