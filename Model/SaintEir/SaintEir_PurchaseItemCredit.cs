using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PurchaseItemCredit
    {
        public int PurchaseItemCreditNo { get; set; }
        public int? PurchaseItemFrom { get; set; }
        public int? BelongToConsumptionHistory { get; set; }
        public int? PurchaseItemTo { get; set; }
        public int? BelongToCredit { get; set; }
        public decimal? CreditPoint { get; set; }
        public int? IsValue { get; set; }
        public int? Flag { get; set; }
        public int? BelongToRemaining { get; set; }
    }
}
