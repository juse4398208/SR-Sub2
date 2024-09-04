namespace Game.Protocol.Communication
{
    /// <summary>
    /// GameSharkErrorMainMessageCode
    /// 鯊皇簡訊內容之對應代碼
    /// </summary>
    public class GameSharkErrorMainMessageCode
    {
        /// <summary>
        /// 無異常
        /// </summary>
        public const int NoError = 0;

        /// <summary>
        /// 前端額度異常
        /// </summary>
        public const int SharkClientPointError = 1;

        /// <summary>
        /// 封包解析錯誤
        /// </summary>
        public const int SharkPackageError = 2;

        /// <summary>
        /// 武器魚倍率錯誤
        /// </summary>
        public const int SharkArmOddsError = 3;

        /// <summary>
        /// 水母倍率錯誤
        /// </summary>
        public const int SharkFGOddsError = 4;
    }
}
