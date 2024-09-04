using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberAllLifeInfo
    {
        /// <summary>
        /// SG 會員歷史總輸贏
        /// </summary>
        public List<MemberAllLifeResult> MemberAllLifeResults { get; set; }

        /// <summary>
        /// 會員首單時間
        /// </summary>
        public List<MemberFirstWager> MemberFirstWagers { get; set; }
    }
}
