namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    public class GameParameterSetting
    {
        /// <summary>
        /// 幣別編號
        /// </summary>
        public List<int> CurrencyID { get; set; }

        /// <summary>
        /// 桌群組編號
        /// </summary>
        public List<GameSetting> BetSettings { get; set; }
    }
}
