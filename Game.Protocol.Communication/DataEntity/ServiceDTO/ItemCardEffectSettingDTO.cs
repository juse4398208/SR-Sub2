namespace Game.Protocol.Communication.DataEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// 道具效果資訊
    /// </summary>
    public class ItemCardEffectSettingDTO
    {
        /// <summary>
        /// ItemCardEffectSettingDTO
        /// </summary>
        public ItemCardEffectSettingDTO()
        {
            this.ItemCardList = new List<ItemCardSettingDTO>();
        }

        /// <summary>
        /// ItemCardEffectID
        /// </summary>
        public long ItemCardEffectID { get; set; }

        /// <summary>
        /// AwardID
        /// </summary>
        public int AwardID { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// FreeCoinType
        /// </summary>
        public int FreeCoinType { get; set; }

        /// <summary>
        /// FreeCoin
        /// </summary>
        public long FreeCoin { get; set; }

        /// <summary>
        /// IsAutoSpin
        /// </summary>
        public bool IsAutoSpin { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Var
        /// </summary>
        public string Var { get; set; }

        /// <summary>
        /// 效果對應到的道具卡資料清單
        /// </summary>
        public List<ItemCardSettingDTO> ItemCardList { get; set; }
    }
}
