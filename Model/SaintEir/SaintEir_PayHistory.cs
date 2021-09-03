using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PayHistory
    {
        public int PayHistoryNo { get; set; }
        public int? BelongToPurchase { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? Paid { get; set; }
        public string PayWay { get; set; }
        public string Command { get; set; }
        public string CreatedBy { get; set; }
        public decimal? TaxPaid { get; set; }
        public int? BelongToInProcess { get; set; }
        public string ANo { get; set; }
        public decimal? DiscountPrice { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual SaintEir_Purchase BelongToPurchaseNavigation { get; set; }
    }
}
