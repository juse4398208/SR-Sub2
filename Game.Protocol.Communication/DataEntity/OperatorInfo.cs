using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// MongoDB - LogUsedWorkAccount
    /// </summary>
    public class OperatorInfo
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int _id { get; set; }

        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        ///  帳號名稱
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        public string OPAccount { get; set; }

        /// <summary>
        /// 等級
        /// </summary>
        public int RankLevel { get; set; }
    }
}
