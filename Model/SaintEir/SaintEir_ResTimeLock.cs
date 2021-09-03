using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ResTimeLock
    {
        public int ResTimeLockNo { get; set; }
        public string BelongToBranch { get; set; }
        public int? LockType { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
