using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ProductOrder
    {
        public string ProductOrderNo { get; set; }
        public string BelongToBranch { get; set; }
        public string ByWhom { get; set; }
        public int? Flag { get; set; }
        public DateTime? GetProductDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public string Note { get; set; }
        public string Supplier { get; set; }
        public string ApplyBy { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string AcceptBy { get; set; }
        public DateTime? AcceptDate { get; set; }
        public int? OrderType { get; set; }
        public string FromProductOrder { get; set; }
    }
}
