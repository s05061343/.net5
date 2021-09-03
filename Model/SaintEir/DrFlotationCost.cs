using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class DrFlotationCost
    {
        public int DrFlotationCostNo { get; set; }
        public int? BelongToCCategory { get; set; }
        public int? BelongToConsumptionHissory { get; set; }
        public int? Amount { get; set; }
        public string Comment { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
