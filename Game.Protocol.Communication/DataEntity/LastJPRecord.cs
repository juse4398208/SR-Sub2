using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class LastJPRecord
    {
        public bool IsOwnJP { get; set; }
        public DateTime? LastAwardTime { get; set; }
    }
}
