using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PurchaseItemStatus
    {
        public int PurchaseItemStatusNo { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public int? NoPhoto { get; set; }
        public int? UnderTwenty { get; set; }
        public int? SpecificPartNote { get; set; }

        public virtual SaintEir_PurchaseItem BelongToPurchaseItemNavigation { get; set; }
    }
}
