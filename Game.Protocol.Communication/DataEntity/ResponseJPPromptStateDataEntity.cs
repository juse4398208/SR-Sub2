using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Protocol.Communication
{
    public class ResponseJPPromptStateDataEntity
    {
        /// <summary>
        /// GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// TableID
        /// </summary>
        public int TableID { get; set; }

        /// <summary>
        /// HallID
        /// </summary>
        public int HallID { get; set; }

        /// <summary>
        /// JPCategoryID
        /// </summary>
        public int JPCategoryID { get; set; }

        /// <summary>
        /// JPPromptState
        /// </summary>
        public bool? JPPromptState { get; set; }
    }
}
