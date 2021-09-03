using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_MemberTotalAmount
    {
        public int? MemberNo { get; set; }
        public decimal? ShouldPay { get; set; }
        public decimal? NotPayYet { get; set; }
        public decimal? refound { get; set; }
        public decimal? TotalCredit { get; set; }
        public decimal? MemberTotalAmount { get; set; }
        public int? 年 { get; set; }
        public int? 月 { get; set; }
        public int? 日 { get; set; }
        public DateTime? PurchaseDate { get; set; }
    }
}
