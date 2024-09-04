using System;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// MemberOnlineInfo
    /// </summary>
    public class MemberOnlineInfo
    {
        /// <summary>
        /// 會員識別號
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// 登入 PNG 時產出的隨機碼
        /// </summary>
        public string LoginToken { get; set; }

        /// <summary>
        /// 會員帳號
        /// </summary>
        public string MemberAccount { get; set; }

        /// <summary>
        /// 會員分類
        /// </summary>
        public int? MemberTypeID { get; set; }

        /// <summary>
        /// 裝置
        /// </summary>
        public int? Platform { get; set; }

        /// <summary>
        /// 遊戲類型ID
        /// </summary>
        public int? GameCategoryID { get; set; }

        /// <summary>
        /// 遊戲廳識別號
        /// </summary>
        public int? HallID { get; set; }

        /// <summary>
        /// 遊戲識別號
        /// </summary>
        public int? GameID { get; set; }

        /// <summary>
        /// 遊戲桌模組ID
        /// </summary>
        public string GameModuleID { get; set; }

        /// <summary>
        /// 桌號
        /// </summary>
        public int? TableID { get; set; }

        /// <summary>
        /// 桌名
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 入桌時間
        /// </summary>
        public DateTime? JoinTableTime { get; set; }

        /// <summary>
        /// 是否中過四層彩金
        /// </summary>
        public bool? IsOwnJP { get; set; }

        /// <summary>
        /// 最後派彩時間
        /// </summary>
        public DateTime? LastAwardTime { get; set; }

        /// <summary>
        /// 登入遊戲館時間
        /// </summary>
        public DateTime? JoinLobbyTime { get; set; }

        /// <summary>
        /// 背景模組名稱
        /// </summary>
        public string BackgroundModuleName { get; set; }

        /// <summary>
        /// 對應特殊遊戲要帶的資訊 Json
        /// </summary>
        public string GameTableInfo { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 底注
        /// </summary>
        public long? Ante { get; set; }

        /// <summary>
        /// 遊戲大廳 -1:清空
        /// </summary>
        public int? GameLobby { get; set; }

        /// <summary>
        /// 使用者資訊
        /// </summary>
        public string UserInfo { get; set; }

        /// <summary>
        /// 是否派彩中 1:是/-1:清空
        /// </summary>
        public int? IsAward { get; set; }

        /// <summary>
        /// 會員進選桌大廳時間
        /// </summary>
        public DateTime? JoinTableListTime { get; set; }

        /// <summary>
        /// 點數(現階段只有7pk有)
        /// </summary>
        public long? MemberExtraPoint { get; set; }

        /// <summary>
        /// 進行NG、FG、BG、LG遊戲
        /// </summary>
        public string GameState { get; set; }

        /// <summary>
        /// 首單時間
        /// </summary>
        public DateTime? FirstWagerTime { get; set; }

        /// <summary>
        /// 是否62天無帳務
        /// </summary>
        public bool? IsSixtyTwoDayWithoutAccounting_10 { get; set; }

        /// <summary>
        /// 最後下注日
        /// </summary>
        public DateTime? LastBetTime_10 { get; set; }

        /// <summary>
        /// 是否62天無帳務
        /// </summary>
        public bool? IsSixtyTwoDayWithoutAccounting_11 { get; set; }

        /// <summary>
        /// 最後下注日
        /// </summary>
        public DateTime? LastBetTime_11 { get; set; }

        /// <summary>
        /// 是否62天無帳務
        /// </summary>
        public bool? IsSixtyTwoDayWithoutAccounting_13 { get; set; }

        /// <summary>
        /// 最後下注日
        /// </summary>
        public DateTime? LastBetTime_13 { get; set; }

        /// <summary>
        /// 是否為(SG)首單背包
        /// </summary>
        public bool? IsAutoSGMemberGameModule { get; set; }

        /// <summary>
        /// 是否為TG背包
        /// </summary>
        public bool? IsAutoTGMemberGameModule { get; set; }

        /// <summary>
        /// 會員背包模組ID(SG)
        /// </summary>
        public string SGMemberGameModuleID { get; set; }

        /// <summary>
        /// TG會員背包相關資訊
        /// </summary>
        public string TGMemberGameModulInfo { get; set; }
    }
}