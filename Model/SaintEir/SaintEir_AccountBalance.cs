using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AccountBalance
    {
        public int AccountBalanceNo { get; set; }
        public string ReceiptNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? Amount { get; set; }
        public string Summary { get; set; }
        public string BelongToTitle { get; set; }
        public string BelongToSupplier { get; set; }
        public int? AccountStatus { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeCashDate { get; set; }
        public int? IsChequeCash { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public string CanelReason { get; set; }
        public string BelongToBranch { get; set; }
        public int? IsReceipt { get; set; }
        public string ReceiptNumber { get; set; }
    }
}
