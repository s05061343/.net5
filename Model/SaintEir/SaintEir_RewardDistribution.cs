using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_RewardDistribution
    {
        public int RewardDistributionNo { get; set; }
        public string BelongToUser { get; set; }
        public DateTime? RewardDate { get; set; }
        public int? BelongToInProcess { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public decimal? RewardPercent { get; set; }
        public decimal? AchievementAmount { get; set; }
        public decimal? AchievementPercent { get; set; }
        public string BelongToBranch { get; set; }
        public int? Flag { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? IsSettleUp { get; set; }
        public decimal? RewardAmountSource { get; set; }
        public int? isPaid { get; set; }
        public int? RewardSign { get; set; }
        public int? RewardStatus { get; set; }
        public int? BelongToProduct { get; set; }
    }
}
