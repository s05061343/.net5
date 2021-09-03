using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class Receipt
    {
        public int BelongToInprocess { get; set; }
        public string ReceiptContent { get; set; }
        public int? Flag { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
