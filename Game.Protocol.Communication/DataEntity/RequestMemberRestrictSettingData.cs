using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Protocol.Communication.Define;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// 請求TG背包異動的資料格式
    /// </summary>
    public class RequestMemberRestrictSettingData
    {
        /// <summary>
        /// 會員ID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// 請求的操作類型
        /// </summary>
        public RequestMemberRestrictSettingType Type { get; set; }

        /// <summary>
        /// 該操作需使用到的資料
        /// </summary>
        public string RequestData { get; set; }
    }
}

/*
 * Add
 *  {
 *   "MemberID" : 123,
 *   "Frequence" : 2,
 *   "RemoveLimit" : 2,
 *   "EventID" : "test_ID",
 *   "ActiveRound" : 2,
 *   "NatureRound" : 2,
 *   "RemoveBetRound" : 2,
 *   "BetRound" : 2,
 *  }
 * 
 * 
 * update
 *  {
 *    "MemberID": 123,
 *    "BetRound": 1
 *  }
 * 
 *
 * delete
 *  {
 *   "MemberID": 123,
 *  }
 * 
 * 
 */