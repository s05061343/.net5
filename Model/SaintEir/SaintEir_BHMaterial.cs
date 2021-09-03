using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BHMaterial
    {
        public int MaterialNo { get; set; }
        public string HQClassCode { get; set; }
        public string MaterialID { get; set; }
        public int? BelongToProduct { get; set; }
        public string NameInChinese { get; set; }
        public string NameInEnglish { get; set; }
        public decimal? CompanyCost { get; set; }
        public decimal? ClientPrice { get; set; }
        public decimal? Cost { get; set; }
        public decimal? PresentQuantity { get; set; }
        public decimal? SafetyQuantity { get; set; }
        public decimal? ConsumptionQuantity { get; set; }
        public string Unit { get; set; }
        public decimal? ConsumptionRatio { get; set; }
        public string ReplenishUnit { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Flag { get; set; }
        public int? IsTrace { get; set; }
        public string BelongToBranch { get; set; }
        public int? BelongToMaterial { get; set; }
        public decimal? CombinationQuantity { get; set; }
        public string MCode { get; set; }
        public int? IsMaterial { get; set; }
        public string Command { get; set; }
        public decimal? PresentSafetyQuantity { get; set; }
        public int Department { get; set; }
    }
}
