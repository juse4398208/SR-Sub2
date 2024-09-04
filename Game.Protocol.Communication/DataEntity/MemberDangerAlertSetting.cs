using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberDangerAlertSetting
    {
        /// <summary>
        /// 警示觸發會員總輸贏 (萬分位)
        /// </summary>
        public long AlertTotalPoint { get; set; }

        /// <summary>
        /// 警示原因，警示群組ID (ID=0相當於不啟用)
        /// </summary>
        public int DangerGroupID { get; set; }

        /// <summary>
        /// 遊戲類別ID
        /// </summary>
        public int GameCategoryID { get; set; }

        /// <summary>
        /// 是否啟用 
        /// </summary>
        public bool IsEnableAlert { get; set; }

        /// <summary>
        /// 連贏天數
        /// </summary>
        public int? WinDays { get; set; }
    }
}
