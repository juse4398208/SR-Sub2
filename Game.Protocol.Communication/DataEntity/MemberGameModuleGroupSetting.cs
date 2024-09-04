using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberGameModuleGroupSetting
    {
        /// <summary>
        /// 背包群組ID
        /// </summary>
        public string GameModuleGroupID { get; set; }

        /// <summary>
        /// 模組ID
        /// </summary>
        public string GameModuleID { get; set; }

        /// <summary>
        /// 模組名稱
        /// </summary>
        public string GameModuleName { get; set; }

        /// <summary>
        /// 模組設定 (ModuleInfo)
        /// </summary>
        public string GameModuleSetting { get; set; }
        
        /// <summary>
        /// 是否自動綁定
        /// </summary>
        public bool InitialPackage { get; set; }
        
        /// <summary>
        /// 開始時間
        /// </summary>
        public DateTime? DateBuild { get; set; }

        /// <summary>
        /// 移除背包群組 洗碼量條件
        /// </summary>
        public long RemovePointRolling { get; set; }

        /// <summary>
        /// 移除背包群組 解除帳務天數條件
        /// </summary>
        public long RemovePointDays { get; set; }
    }
}
