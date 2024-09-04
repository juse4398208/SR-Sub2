using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class MemberDisableGameInfo
    {
        public long MemberID { get; set; }

        public List<int> DisableGameIDs { get; set; }
    }
}
