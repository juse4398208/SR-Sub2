namespace Game.Protocol.Communication.DataEntity
{
    using System;

    /// <summary>
    /// 道具相關資訊
    /// </summary>
    public class ItemCardSettingDTO
    {
        /// <summary>
        /// ItemCardID
        /// </summary>
        public long ItemCardID { get; set; }

        /// <summary>
        /// IsTrade
        /// </summary>
        public bool IsTrade { get; set; }

        /// <summary>
        /// Stacked
        /// </summary>
        public int Stacked { get; set; }

        /// <summary>
        /// LvLimit
        /// </summary>
        public int LvLimit { get; set; }

        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// GameCName
        /// </summary>
        public string GameCName { get; set; }

        /// <summary>
        /// HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// HallName
        /// </summary>
        public string HallName { get; set; }

        /// <summary>
        /// CardEffectID
        /// </summary>
        public long CardEffectID { get; set; }

        /// <summary>
        /// Expend
        /// </summary>
        public int Expend { get; set; }

        /// <summary>
        /// ExistenceTime
        /// </summary>
        public string ExistenceTime { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// ItemName
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// ItemInfo
        /// </summary>
        public string ItemInfo { get; set; }

        /// <summary>
        /// IsEnable
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// ItemInfo
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// UpdateDate
        /// </summary>
        public DateTime UpdateDate { get; set; }

    }
}
