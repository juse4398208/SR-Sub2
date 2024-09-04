using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.Define
{
    /// <summary>
    /// TG背包請求的類型
    /// </summary>
    public enum RequestMemberRestrictSettingType
    {
        /// <summary>
        /// 新增
        /// </summary>
        ADD = 1,

        /// <summary>
        /// 更新
        /// </summary>
        UPDATE = 2,

        /// <summary>
        /// 移除(僅改成不啟用，不是真正意義上的移除)
        /// </summary>
        DELETE = 3,
    }
}
