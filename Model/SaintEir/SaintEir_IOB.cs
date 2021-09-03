using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_IOB
    {
        public int IOBNo { get; set; }
        public string NoteNo { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public decimal? AfterTaxPrice { get; set; }
        public decimal? BeforeTaxPrice { get; set; }
        public decimal? Tax { get; set; }
        public DateTime? IOBDate { get; set; }
        public int? BelongToSupplier { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Flag { get; set; }
        public string VoucherNo { get; set; }
        public string BelongToBranch { get; set; }
        public int? Status { get; set; }
        public int? IsReceipt { get; set; }
        public string ReceiptNumber { get; set; }
    }
}
