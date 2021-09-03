using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AchievementDistribution
    {
        public int AchievementDisNo { get; set; }
        public string BelongToUser { get; set; }
        public DateTime? AchievementData { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public decimal? Amount { get; set; }
        public string BelongToBranch { get; set; }
        public int? Flag { get; set; }
        public int? IsSettleUp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? RewardPercent { get; set; }
    }
}
