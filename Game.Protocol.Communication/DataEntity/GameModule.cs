namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// GameModule
    /// 遊戲模組
    /// </summary>
    public class GameModule
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public GameModule()
        {
            this.ID = string.Empty;
            this.Setting = string.Empty;
            this.DelaySecond = -1;
            this.opAccount = string.Empty;
            this.IsModifyModuleParmeters = false;
        }

        #region Property

        /// <summary>
        /// Gets or sets ModuleID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ModuleSetting
        /// </summary>
        public string Setting { get; set; }

        /// <summary>
        /// Gets or sets RTPLevel
        /// </summary>
        public string RTPLevel { get; set; }

        /// <summary>
        /// Gets or sets DelaySecond
        /// </summary>
        public int DelaySecond { get; set; }

        /// <summary>
        /// 操作者帳號
        /// </summary>
        public string opAccount { get; set; }
        
        /// <summary>
        /// Gets or sets ModuleName
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// Gets or sets IsModifyModuleParmeters 是否更新特色參數
        /// </summary>
        public bool IsModifyModuleParmeters { get; set; } = false;

        #endregion Property

        #region Method

        /// <summary>
        /// ReSet
        /// </summary>
        public void ReSet()
        {
            this.ID = string.Empty;
            this.Setting = string.Empty;
            this.DelaySecond = -1;
            this.opAccount = string.Empty;
            this.ModuleName = string.Empty;
            this.IsModifyModuleParmeters = false;
        }

        #endregion Method
    }
}
