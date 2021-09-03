using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class DailyDealUser
    {
        public int DailyDealUserNo { get; set; }
        public DateTime? StaticDate { get; set; }
        public string BelongToBranch { get; set; }
        public string BelongToUser { get; set; }
        public string CustomerType { get; set; }
        public int? EntryCount { get; set; }
        public int? EntryCountExt { get; set; }
        public int? DealCount { get; set; }
        public int? DealAmount { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
