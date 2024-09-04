namespace Game.Protocol.Communication
{
    /// <summary>
    /// MESSAGE_PROTO_GL_To_GTL
    /// </summary>
    public enum MESSAGE_PROTO_GL_To_GTL
    {
        /// <summary>
        /// TestMsg 測試用訊息
        /// </summary>
        SEND_TEST_MESSAGE = 0,

        /// <summary>
        /// SEND_MARQUEE 跑馬燈
        /// </summary>
        SEND_MARQUE = 1,

        /// <summary>
        /// SEND_ROUND_INFO 局資訊
        /// </summary>
        SEND_ROUND_INFO = 2,

        /// <summary>
        /// WRITE_FORCE_WIN_AWARD_RESULT 寫入強制贈獎結果
        /// </summary>
        WRITE_FORCE_WIN_AWARD_RESULT = 3,

        /// <summary>
        /// SEND_GAME_DISPLAYINFO 遊戲顯示資訊
        /// </summary>
        SEND_GAME_DISPLAYINFO = 4,

        /// <summary>
        /// SEND_LEAVE_GAME GL請求解散遊戲
        /// </summary>
        SEND_LEAVE_GAME = 5,

        /// <summary>
        /// SEND_UPDATE_PEOPLECOUNT 更新遊戲人數
        /// </summary>
        SEND_UPDATE_PEOPLECOUNT = 6,

        /// <summary>
        /// SEND_UPDATE_MEMBER_STATE 更新玩家狀態
        /// </summary>
        SEND_UPDATE_MEMBER_STATE = 7,

        /// <summary>
        /// SEND_RESPONSE_KICK_MEMBER_INFO 回覆踢除玩家
        /// </summary>
        SEND_RESPONSE_KICK_MEMBER_INFO = 8,

        /// <summary>
        /// SEND_MEMBER_DEDUCT_POINT_RESULT 通知會員扣點
        /// </summary>
        SEND_MEMBER_DEDUCT_POINT_RESULT = 9,

        /// <summary>
        /// SEND_CANCEL_AWARD_RESULT 回寫取消派彩結果
        /// </summary>
        SEND_CANCEL_AWARD_RESULT = 10,

        /// <summary>
        /// SEND_RESERVE_SEATS 請求此座位保留
        /// </summary>
        SEND_RESERVE_SEATS = 11,

        /// <summary>
        /// SEND_ALREADY_SEATED 玩家已完成入桌
        /// </summary>
        SEND_ALREADY_SEATED = 12,

        /// <summary>
        /// SEND_REFRESH_ACCMULATELIST 更新中獎列表
        /// </summary>
        SEND_REFRESH_ACCMULATELIST = 13,

        /// <summary>
        /// SEND_UPDATE_MEMBER_LEVEL 更新等級異動
        /// </summary>
        NO_USE_01 = 14,

        /// <summary>
        /// SEND_DEMON 666惡魔(強制解散)
        /// </summary>
        SEND_DEMON = 666,
    }
}
