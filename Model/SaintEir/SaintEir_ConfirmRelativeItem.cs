using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ConfirmRelativeItem
    {
        public int ConfirmRelativeItemNo { get; set; }
        public int? BelongToConsumptionHistory { get; set; }
        public string ValueType { get; set; }
        public int? ValueNo { get; set; }
        public int? BelongToConfirmRelative { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
