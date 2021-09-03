using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class RegularVoucher
    {
        public int RegularVoucherNo { get; set; }
        public string Title { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Description { get; set; }
        public int? TotalAmount { get; set; }
        public int? Interval { get; set; }
        public int? Days { get; set; }
        public int? FirstCount { get; set; }
        public int? TotalCount { get; set; }
        public int? CurrentCount { get; set; }
        public int? Remainder { get; set; }
        public int? Status { get; set; }
        public int? Flag { get; set; }
        public string BelongToBranch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
