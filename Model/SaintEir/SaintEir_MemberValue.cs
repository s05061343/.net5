using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MemberValue
    {
        public int MemberValueNo { get; set; }
        public int? BelongToMember { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? OwnMoney { get; set; }
        public int? DealCount { get; set; }
        public int? ComeInCount { get; set; }
        public int? VYear { get; set; }
        public int? VMonth { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
