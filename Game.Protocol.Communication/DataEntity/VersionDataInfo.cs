using Game.Protocol.Communication.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication.DataEntity
{
    public class VersionDataInfo
    {
        /// <summary>
        /// APName Server名稱
        /// </summary>
        public string ApName { get; set; }

        /// <summary>
        /// Version 版本號
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 版本類別
        /// </summary>
        public VersionDataType VersionType { get; set; }

        /// <summary>
        /// 遊戲ID
        /// </summary>
        public string GameID { get; set; }
    }
}
