using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AccountingTitle
    {
        public int AccountingTitleNo { get; set; }
        public string AccountingClassify { get; set; }
        public string AccountCode { get; set; }
        public string AccountTitleCht { get; set; }
        public int? AccountTitleStatus { get; set; }
        public string BelongToClassify { get; set; }
        public int? IsReduce { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Flag { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string BelongToBranch { get; set; }
        public int? IsCashFlow { get; set; }
    }
}
