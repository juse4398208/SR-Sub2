namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// CGActivitySetting
    /// </summary>
    public class CGActivitySetting
    {
        /// <summary>
        /// 活動編號
        /// </summary>
        public int ActivitySerial { get; set; }

        /// <summary>
        /// 多筆遊戲編號
        /// </summary>
        public List<int> GameList { get; set; }

        /// <summary>
        /// 參數設定
        /// </summary>
        public List<GameParameterSetting> ParameterSettings { get; set; }

        /// <summary>
        /// 多筆時間設定
        /// </summary>
        public List<TimeSetting> TimeSettings { get; set; }

        /// <summary>
        /// 贏分表
        /// </summary>
        public List<GameResult> AllWinPointList { get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 功能類型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 是否啟用自動派彩
        /// true : 啟用
        /// false : 停用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 保底率
        /// </summary>
        public int GuaranteedRate { get; set; }

        /// <summary>
        /// 操作者詳細資訊
        /// </summary>
        public OperatorInfo OperatorInfo { get; set; }
    }
}
