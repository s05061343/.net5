using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class RegularVoucherItem
    {
        public int RegularVoucherItemNo { get; set; }
        public int? BelongToRegularVoucher { get; set; }
        public DateTime? OperationDate { get; set; }
        public int? IsVoucher { get; set; }
        public int? Amount { get; set; }
        public string Summary { get; set; }
        public int? BelongToTitle { get; set; }
        public int? BelongToSupplier { get; set; }
        public int? AccountStatus { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeCashDate { get; set; }
        public int? IsChequeCash { get; set; }
        public int? IsReceipt { get; set; }
        public string ReceiptNumber { get; set; }
        public string CashFlowClassify { get; set; }
    }
}
