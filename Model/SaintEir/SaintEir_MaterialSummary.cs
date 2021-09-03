using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MaterialSummary
    {
        public int MaterialSummaryNo { get; set; }
        public DateTime? dateTime { get; set; }
        public int? BelongToMaterial { get; set; }
        public string BelongToBranch { get; set; }
        public decimal? BeginningQuantity { get; set; }
        public decimal? BeginningUnitPrice { get; set; }
        public decimal? BeginningAmount { get; set; }
        public decimal? ReplenishQuantity { get; set; }
        public decimal? ReplenishUnitPrice { get; set; }
        public decimal? ReplenishAmount { get; set; }
        public decimal? ConsumptionQuantity { get; set; }
        public decimal? ConsumptionUnitPrice { get; set; }
        public decimal? ConsumptionAmount { get; set; }
        public decimal? AdjustQuantity { get; set; }
        public decimal? AdjustUnitPrice { get; set; }
        public decimal? AdjustAmount { get; set; }
        public decimal? FinalQuantity { get; set; }
        public decimal? FinalUnitPrice { get; set; }
        public decimal? FinalAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
