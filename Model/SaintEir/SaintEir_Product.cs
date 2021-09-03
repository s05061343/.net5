using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Product
    {
        public int ProductKeyNo { get; set; }
        public string ProductNo { get; set; }
        public string NameInChinese { get; set; }
        public string NameInEnglish { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MemberPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public string PicFileName { get; set; }
        public string Description { get; set; }
        public string KeyWord { get; set; }
        public string Unit { get; set; }
        public int? Quantity { get; set; }
        public string RelatedProducts { get; set; }
        public string BelongToBranch { get; set; }
        public string BelongToClassify { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Command { get; set; }
        public decimal? FollowerReward { get; set; }
        public decimal? CreditValue { get; set; }
        public int? IsShow { get; set; }
        public int? IsDynamicMaterial { get; set; }
        public int? CostTime { get; set; }
        public decimal? SAReward { get; set; }
        public int? IsMaterial { get; set; }
        public decimal? MaterialEstimate { get; set; }
        public int? IsValidDate { get; set; }
        public int? ValidDays { get; set; }
        public decimal? StatisticUnit { get; set; }
        public decimal? RewardPercet { get; set; }
        public int? Category { get; set; }
        public int? IsValue { get; set; }
        public int ValidationRule { get; set; }
        public int ReminderRule { get; set; }
        public int DefaultTradeType { get; set; }
        public int RequireSelectMaterial { get; set; }
    }
}
