using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AdditionalLeaveUsageLog
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int TakeOffId { get; set; }
        public decimal UsedHours { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
        public string Memo { get; set; }
    }
}
