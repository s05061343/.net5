using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class DailyOperationStatic
    {
        public int DailyOperationStaticNo { get; set; }
        public DateTime? StaticDate { get; set; }
        public string BranchNo { get; set; }
        public string ServiceUser { get; set; }
        public int? BelongToCCategory { get; set; }
        public string CustomerType { get; set; }
        public int? EntryCount { get; set; }
        public int? DealCount { get; set; }
        public int? DealAmount { get; set; }
        public int? RefundAmount { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
