using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SalesRanking
    {
        public int SalesRankingNo { get; set; }
        public string PurchaseItemNo { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public string BranchNo { get; set; }
        public DateTime? StaticDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
