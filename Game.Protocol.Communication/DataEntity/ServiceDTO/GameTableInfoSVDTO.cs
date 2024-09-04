namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// GameTableInfoSVDTO
    /// </summary>
    public class GameTableInfoSVDTO
    {
        public bool IsFinal { get; set; }

        public int GameID { get; set; }

        public int HallID { get; set; }

        public int TableID { get; set; }

        public string TableName { get; set; }

        public long RoundID { get; set; }

        public string GameLogicAssemblyName { get; set; }

        public string GameLogicTypeName { get; set; }

        public string GameTableLogicAssemblyName { get; set; }

        public string GameTableLogicTypeName { get; set; }

        public int TableGroupID { get; set; }

        public string GameJson { get; set; }

        public string GameTableRule { get; set; }

        public string SubRule { get; set; }

        public string GameModuleID { get; set; }

        public string ProbInfo { get; set; }

        public string GameInfo { get; set; }

        public string MemberInfo { get; set; }

        public bool IsInitLoad { get; set; }

        public bool IsEnable { get; set; }

        public int Fps { get; set; }

        public bool IsReleaseGameTable { get; set; }

        public string TableOtherSetting { get; set; }

        public string StatisticalInfo { get; set; }

        public string StatisticalHistory { get; set; }
        /// <summary>
        /// 最低入桌LevelGroup
        /// </summary>
        public int MemberLevelGroupLimit { get; set; }
        /// <summary>
        /// 單局上限
        /// </summary>
        public long MaxCarryPoint { get; set; }

        /// <summary>
        /// 此底注區最大玩家數
        /// </summary>
        public int MaxPlayer { get; set; }
    }
}
