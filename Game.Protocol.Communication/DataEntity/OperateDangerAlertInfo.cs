using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Protocol.Communication.Define;

namespace Game.Protocol.Communication.DataEntity
{
    public class OperateDangerAlertInfo
    {
        /// <summary>
        /// 會員ID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// 會員帳號
        /// </summary>
        public string MemberAccount { get; set; }

        /// <summary>
        /// 遊戲類別ID
        /// </summary>
        public int GameCategoryID { get; set; }

        /// <summary>
        /// 警示群組ID
        /// </summary>
        public int DangerGroupID { get; set; }

        /// <summary>
        /// 自動警示操作類型
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// 異動時間(UTC)
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
