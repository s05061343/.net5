using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Credit
    {
        public int CreditNo { get; set; }
        public DateTime? CreditDate { get; set; }
        public int? BelongToMember { get; set; }
        public string Comment { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalCredit { get; set; }
        public decimal? RemainCredit { get; set; }
        public int? BelongToPurchase { get; set; }
        public string CardNo { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Flag { get; set; }
        public string BelongToBranch { get; set; }
        public int? Type { get; set; }
        public int? BelongToInprocess { get; set; }
        public DateTime? RetriveDate { get; set; }
        public string RetriveBy { get; set; }
        public int? CreditFromMember { get; set; }
        public int PurchaseTo { get; set; }
    }
}
