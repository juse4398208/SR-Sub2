namespace Game.Protocol.Communication.DataEntity
{
    /// <summary>
    /// Force win award result
    /// </summary>
    public class ForceWinAwardResult
    {
        /// <summary>
        /// Gets or sets AwardSerial
        /// </summary>
        public string AwardSerial { get; set; }

        /// <summary>
        /// Gets or sets BetPoint
        /// </summary>
        public long BetPoint { get; set; }

        /// <summary>
        /// Gets or sets AwardPoint
        /// </summary>
        public long AwardPoint { get; set; }

        /// <summary>
        /// Gets or sets AwardTime
        /// </summary>
        public double AwardTime { get; set; }

        /// <summary>
        /// Gets or sets IsAward
        /// </summary>
        public bool IsAward { get; set; }

        /// <summary>
        /// Gets or sets Details
        /// Sample:
        /// {
        ///     "WagerSerials":[
        ///         "01014014-07DF0C1E00001-000",
        ///         "01014014-07DF0C1E00002-000",
        ///         "01014014-07DF0C1E00003-000"
        ///     ]
        /// }
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// GameModuleID
        /// </summary>
        public string GameModuleID { get; set; }

        /// <summary>
        /// IsAuto
        /// </summary>
        public bool IsAuto { get; set; }

        /// <summary>
        /// MemberID
        /// </summary>
        public long MemberID { get; set; }

        /// <summary>
        /// AwardID
        /// </summary>
        public int AwardID { get; set; }

        /// <summary>
        /// IsNPC
        /// </summary>
        public int IsNPC { get; set; }

        /// <summary>
        /// JPID
        /// </summary>
        public int JPID { get; set; }

        /// <summary>
        /// FailReason
        /// </summary>
        public int FailReason { get; set; }

        /// <summary>
        /// ForceWinAwardResult
        /// </summary>
        public ForceWinAwardResult()
        {
            this.AwardSerial = string.Empty;
            this.BetPoint = 0;
            this.AwardPoint = 0;
            this.AwardTime = 0;
            this.IsAward = false;
            this.Details = "";
            this.GameModuleID = string.Empty;
            this.IsAuto = false;
            this.MemberID = -1;
            this.AwardID = -1;
            this.IsNPC = 0;
            this.JPID = -1;
            this.FailReason = 0;
        }
    }
}
