using Game.Protocol.Communication.Define;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// 平台登入時帶入的資訊 (解析平台帶入資料用)
    /// </summary>
    public class PlatformLoginData
    {
        /// <summary>
        /// PlatformLoginData
        /// </summary>
        public PlatformLoginData()
        {
            // 防呆: 預設用一般帳號進入, 避免反序列化時缺少 MemberType 欄位而造成以試玩帳號進入遊戲
            MemberType = PlatformMemberType.Normal;
        }

        /// <summary>
        /// 平台登入時的會員類型
        /// </summary>
        public PlatformMemberType MemberType { get; set; }

        /// <summary>
        /// 平台登入時的會員等級
        /// </summary>
        public int MemberLevel { get; set; }

        /// <summary>
        /// 玩家登入的擴充資訊
        /// </summary>
        public ClientLoginData CInfo { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"MemberType: { this.MemberType }, MemberLevel: { this.MemberLevel }, CInfo: {this.CInfo}";
        }
    }

    /// <summary>
    /// 玩家登入的擴充資訊
    /// </summary>
    public class ClientLoginData
    {
        /// <summary>
        /// 登入類型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 前次登入使用的UID
        /// </summary>
        public string UserConnectUID { get; set; }

        /// <summary>
        /// 前次登入最後收到的OrderID
        /// </summary>
        public int CheckOrderID { get; set; }

        /// <summary>
        /// 裝置
        /// </summary>
        public PlatformCategory PlatformID { get; set; }
    }
}
