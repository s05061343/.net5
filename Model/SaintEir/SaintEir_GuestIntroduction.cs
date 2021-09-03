using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_GuestIntroduction
    {
        public int Id { get; set; }
        public int? IntroducerMemberNo { get; set; }
        public int? NewCustomerMemberNo { get; set; }
        public int? BelongToPurchaseNo { get; set; }
        public int? ConsumptionCount { get; set; }
        public decimal? ConsumptionAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
