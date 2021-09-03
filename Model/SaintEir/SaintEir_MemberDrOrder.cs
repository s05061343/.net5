using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MemberDrOrder
    {
        public int MemberDrOrderNo { get; set; }
        public int? BelongToConsumption { get; set; }
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public string OrderPlan { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? Flag { get; set; }
        public int? BelongToMember { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
