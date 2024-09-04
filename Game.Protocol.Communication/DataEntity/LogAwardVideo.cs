using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class LogAwardVideo
    {
        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// AwardVideoSetting
        /// </summary>
        public List<string> AwardVideoSetting { get; set; }

        /// <summary>
        /// wagerSerial
        /// </summary>
        public string WagerSerial { get; set; }

        /// <summary>
        /// DateBuild
        /// </summary>
        public DateTime DateBuild { get; set; }

        /// <summary>
        /// State
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// VideoName
        /// </summary>
        public string VideoName { get; set; }

        /// <summary>
        /// JSListJsonString
        /// </summary>
        public string JSListJsonString { get; set; }

        /// <summary>
        /// CustomizedData
        /// </summary>
        public string CustomizedData { get; set; }

        /// <summary>
        /// NickName
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 下注額度
        /// </summary>
        public long Bet { get; set; }

        /// <summary>
        /// OriginalCredit
        /// </summary>
        public long OriginalCredit { get; set; }

        /// <summary>
        /// MemberLevel
        /// </summary>
        public int MemberLevel { get; set; }

        /// <summary>
        /// GameCardID 電子館道具卡序號
        /// </summary>
        public long GameCardID { get; set; } = -1;

        /// <summary>
        /// 是否獎項為JP
        /// </summary>
        public bool IsJP { get; set; }
    }
}
