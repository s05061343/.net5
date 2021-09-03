using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class ReceiptItem
    {
        public int ReceiptItemNo { get; set; }
        public int? BelongToInprocess { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public int? BelongToProduct { get; set; }
        public decimal? Amount { get; set; }
        public int? DownPayment { get; set; }
    }
}
