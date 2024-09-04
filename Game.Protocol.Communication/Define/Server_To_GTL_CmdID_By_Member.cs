namespace Game.Protocol.Communication
{
    public enum Server_To_GTL_CmdID_By_Member
    {
        /// <summary>
        /// AS傳送給GTS的更新會員背包限制設定
        /// </summary>
        AS_TO_GTL_NOTIFY_UPDATE_MEMBER_RESTRICT_SETTING = 5001,

        //AS通知GTS 更新會員警示資料
        AS_TO_GTL_NOTIFY_UPDATE_MEMBER_WARNING_SETTING = 5002,
    }
}
