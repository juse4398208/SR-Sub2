namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// DisplayInfo
    /// 遊戲設定
    /// </summary>
    public class ModifySubRule
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public ModifySubRule()
        {
            this.SubRule = string.Empty;
            this.ModifyItem = string.Empty;
        }

        #region Property

        /// <summary>
        /// Gets or sets GameInfo 遊戲資訊
        /// </summary>
        public string SubRule { get; set; }

        /// <summary>
        /// Gets or sets ModifyItem 修改項目
        /// </summary>
        public string ModifyItem { get; set; }

        #endregion Property
    }
}
