using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Remaining
    {
        public int RemainingNo { get; set; }
        public int? BelongToMember { get; set; }
        public int? ProductNo { get; set; }
        public int? Quantity { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public string BelongToBranch { get; set; }
        public decimal? SA { get; set; }
        public int? Flag { get; set; }
        public int? IsValidDate { get; set; }
        public DateTime? ValidDate { get; set; }
    }
}
