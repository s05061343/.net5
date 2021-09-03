using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CashFlowStatement
    {
        public int CashFlowStatementNo { get; set; }
        public int? BelongToClassify { get; set; }
        public int? BelongToAccountBalance { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
