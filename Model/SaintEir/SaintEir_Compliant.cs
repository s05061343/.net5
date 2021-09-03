using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Compliant
    {
        public int CompliantNo { get; set; }
        public int? BelongToMember { get; set; }
        public int? Progress { get; set; }
        public int? BelongToConsumptionHistory { get; set; }
        public string ByDr { get; set; }
        public string ByFollowerA { get; set; }
        public string ByFollowerB { get; set; }
        public string ByChecker { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? CompliantDate { get; set; }
        public string Description { get; set; }
        public decimal? LossAmount { get; set; }
        public string LossDescription { get; set; }
        public int? HasAffidavit { get; set; }
        public int? HasRefund { get; set; }
        public DateTime? EndDate { get; set; }
        public string Responsibility { get; set; }
        public int? ProcessUnit { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
