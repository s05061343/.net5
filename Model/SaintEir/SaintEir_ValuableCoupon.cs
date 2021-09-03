using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ValuableCoupon
    {
        public int ValuableCouponNo { get; set; }
        public string NoteNo { get; set; }
        public int? BelongToMember { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? BelongToInProcess { get; set; }
        public int? Flag { get; set; }
        public decimal? CouponWorth { get; set; }
        public string Comment { get; set; }
        public int? IsUsed { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
