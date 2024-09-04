using System.Collections.Generic;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberTGAllLifeInfo
    {
        /// <summary>
        /// 會員TG歷史總輸贏
        /// </summary>
        public MemberTGAllLifeResult MemberAllLifeResult { get; set; }

        /// <summary>
        /// 會員首單時間
        /// </summary>
        public List<MemberFirstWager> MemberFirstWagers { get; set; }
    }
}