using System.Collections.Generic;

namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// GameModuleInfoSVDTO
    /// </summary>
    public class GameModuleInfoSVDTO
    {
        public int GameID { get; set; }
        public string GameModuleID { get; set; }
        public string Name { get; set; }
        public string Setting { get; set; }
        public bool IsFinal { get; set; }
    }
}
