using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DRReward
    {
        public int DRRewardNo { get; set; }
        public int? ItemCode { get; set; }
        public string BelongToLoginUser { get; set; }
        public string CustomerName { get; set; }
        public int? MemberNo { get; set; }
        public decimal? RewardPercentage { get; set; }
        public decimal? SoldOutPrice { get; set; }
        public int? Quantity { get; set; }
        public decimal? RewardMoney { get; set; }
        public decimal? CostFee { get; set; }
        public decimal? FlotationCost { get; set; }
        public decimal? IntroFee { get; set; }
        public int? BelongToIntroducer { get; set; }
        public decimal? RewardAmout { get; set; }
        public int? BelongToPurchaseItemNo { get; set; }
        public int? BelongToHistory { get; set; }
        public string ClassifyName { get; set; }
        public string BelongToANo { get; set; }
        public DateTime? RewardDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string BelongToBranch { get; set; }
        public string Expression { get; set; }
        public int Lock { get; set; }
        public int IsRation { get; set; }
        public int PurchaseItemType { get; set; }
        public DateTime? RationDate { get; set; }
        public int RationFlag { get; set; }
    }
}
