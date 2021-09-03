using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MaterialConsumption
    {
        public int MaterialConsumptionNo { get; set; }
        public int? BelongToConsumptionHistory { get; set; }
        public int? BelongToMaterial { get; set; }
        public decimal? Quantity { get; set; }
        public int? BelongToBHMaterial { get; set; }
        public decimal? BHMaterialQuantity { get; set; }
        public int? Flag { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string IOBNoteNO { get; set; }
        public int? ExReType { get; set; }
        public int? BelongToCredit { get; set; }
        public DateTime? ConsumptionDate { get; set; }
        public string Comment { get; set; }
        public string BelongToBranch { get; set; }
    }
}
