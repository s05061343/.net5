using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BranchAchievement
    {
        public int AchievementDisNo { get; set; }
        public DateTime? AchievementDate { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public decimal? AchievementAmount { get; set; }
        public string BelongToBranch { get; set; }
        public int? Flag { get; set; }
        public int? RewardSign { get; set; }
        public int? IsSettleUp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
