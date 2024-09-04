namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Game table parameter
    /// </summary>
    public class GameTableParameter
    {
        #region Property

        /// <summary>
        /// Gets or set GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Gets or set TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// Gets or set RoundID
        /// </summary>
        public long RoundID { get; set; }

        /// <summary>
        /// Gets or set TableGroupID
        /// </summary>
        public int TableGroupID { get; set; }

        /// <summary>
        /// Gets or sets GameTableRule
        /// </summary>
        public string GameTableRule { get; set; }

        /// <summary>
        /// Gets or sets Subrule
        /// </summary>
        public string Subrule { get; set; }

        /// <summary>
        /// Gets or sets GameModuleID
        /// </summary>
        public string GameModuleID { get; set; }

        /// <summary>
        /// GameModuleName
        /// </summary>
        public string GameModuleName { get; set; }

        /// <summary>
        /// Gets or sets GameModuleSetting
        /// </summary>
        public string GameModuleSetting { get; set; }

        /// <summary>
        /// Gets or sets ProbInfo
        /// </summary>
        public string ProbInfo { get; set; }

        /// <summary>
        /// Gets or sets GameInfo
        /// </summary>
        public string GameInfo { get; set; }

        /// <summary>
        /// Gets or sets MemberInfo
        /// </summary>
        public string MemberInfo { get; set; }

        /// <summary>
        /// Gets or sets StatisticalInfo
        /// </summary>
        public string StatisticalInfo { get; set; }

        /// <summary>
        /// Gets or sets StatisticalHistory
        /// </summary>
        public string StatisticalHistory { get; set; }

        /// <summary>
        /// Gets or sets LuckJPModuleSetting
        /// </summary>
        public string LuckyJPModuleSetting { get; set; }

        /// <summary>
        /// Gets or sets IsReleaseGameTable
        /// </summary>
        public bool IsReleaseGameTable { get; set; }

        /// <summary>
        /// 遊戲桌額外設定
        /// </summary>
        public string TableOtherSetting { get; set; }

        /// <summary>
        /// Gets or sets DistributionID
        /// </summary>
        public int DistributionID { get; set; }

        #endregion Property

        #region Method

        /// <summary>
        /// Overrde Object.ToString()
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                "GameID: {0}, TableID: {1}, RoundID: {2}, " +
                "TableGroupID: {3}, GameTableRule: {4}, Subrule: {5}, " +
                "GameModuleID: {6}, GameModuleSetting: {7}, ProbInfo: {8}, GameInfo: {9}, MemberInfo: {10}, " +
                "StatisticalInfo: {11}, StatisticalHistory: {12}, IsReleaseGameTable:{13}, TableOtherSetting: {14}, DistributionID: {15}",
                GameID,
                TableID,
                RoundID,
                TableGroupID,
                GameTableRule,
                Subrule,
                GameModuleID,
                GameModuleSetting,
                ProbInfo,
                GameInfo,
                MemberInfo,
                StatisticalInfo,
                StatisticalHistory,
                IsReleaseGameTable,
                TableOtherSetting,
                DistributionID);
        }

        #endregion Method
    }
}
