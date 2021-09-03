using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SaleReward
    {
        public int SaleRewardNo { get; set; }
        public int? ItemCode { get; set; }
        public string BelongToLoginUser { get; set; }
        public string CustomerName { get; set; }
        public int? MemberNo { get; set; }
        public decimal? RewardPercentage { get; set; }
        public decimal? AchievementAmount { get; set; }
        public decimal? SoldOutPrice { get; set; }
        public decimal? IntroFee { get; set; }
        public int? BelongToIntroducer { get; set; }
        public decimal? RewardAmout { get; set; }
        public int? BelongToPurchaseItemNo { get; set; }
        public string IsPackageOrProduct { get; set; }
        public int? SaleCount { get; set; }
        public string ClassifyName { get; set; }
        public DateTime? RewardDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ProductClassify { get; set; }
        public decimal? RewardAmountSource { get; set; }
        public int? RewardSign { get; set; }
        public int? RewardStatus { get; set; }
        public int? BelongToPackage { get; set; }
        public int? BelongToProduct { get; set; }
    }
}
