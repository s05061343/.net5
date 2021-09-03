using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class DailyDealUserCategory
    {
        public int DailyDealUserCategoryNo { get; set; }
        public DateTime? StaticDate { get; set; }
        public string BelongToBranch { get; set; }
        public string BelongToUser { get; set; }
        public int? BelongToCCategory { get; set; }
        public string CustomerType { get; set; }
        public int? EntryCount { get; set; }
        public int? DealCount { get; set; }
        public int? DealAmount { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
