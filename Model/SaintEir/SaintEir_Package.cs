using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Package
    {
        public int PackageKeyNo { get; set; }
        public string PackageNo { get; set; }
        public string NameInChinese { get; set; }
        public string NameInEnglish { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? OriginalPrice { get; set; }
        public decimal? PackagePrice { get; set; }
        public decimal? PackageMinPrice { get; set; }
        public decimal? PackageMaxPrice { get; set; }
        public decimal? PackageSellPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public string BelongToBranch { get; set; }
        public string BelongToClassify { get; set; }
        public int? Flag { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Command { get; set; }
        public string ClassifySet { get; set; }
        public int? IsValidDate { get; set; }
        public int? ValidDays { get; set; }
        public int? Category { get; set; }
        public int DefaultTradeType { get; set; }
    }
}
