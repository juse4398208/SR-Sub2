using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberModuleGroupSetting
    {
        public long MemberID { get; set; }
        public string ModuleGroupID { get; set; }
        public bool IsEnable { get; set; }
    }
}
