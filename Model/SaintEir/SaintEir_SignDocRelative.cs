using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SignDocRelative
    {
        public int SignDocRelativeNo { get; set; }
        public int? BelongToSignDoc { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string TempIndex { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public int? BelongToConsumptionHistory { get; set; }

        public virtual SaintEir_ComsumptionHistory BelongToConsumptionHistoryNavigation { get; set; }
        public virtual SaintEir_PurchaseItem BelongToPurchaseItemNavigation { get; set; }
        public virtual SaintEir_SignDoc BelongToSignDocNavigation { get; set; }
    }
}
