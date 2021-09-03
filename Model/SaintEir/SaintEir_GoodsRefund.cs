using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_GoodsRefund
    {
        public int GoodsRefundNo { get; set; }
        public DateTime? RefundDate { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public int? BelongToProduct { get; set; }
        public int? Quantity { get; set; }
        public decimal? ProductWorth { get; set; }
        public string Note { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Flag { get; set; }
        public int? BelongToCredit { get; set; }
        public decimal? Credit { get; set; }
        public string BelongToBranch { get; set; }
    }
}
