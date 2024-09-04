namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// 傳給UC的一些資料
    /// </summary>
    public class ResponseUCOtherInfo
    {
        /// <summary>
        /// PlatformLoginData
        /// </summary>
        public ResponseUCOtherInfo()
        {
            
        }

        /// <summary>
        /// cLog API 的路徑
        /// </summary>
        public string CLogAPIURL { get; set; }
 
        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"CLogAPIURL: { this.CLogAPIURL }";
        }
    }
}
