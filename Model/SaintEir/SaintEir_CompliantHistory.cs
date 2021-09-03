using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CompliantHistory
    {
        public int CompliantHistoryNo { get; set; }
        public int? BelongToCompliant { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? FollowOn { get; set; }
        public DateTime? FollowDate { get; set; }
        public int? Flag { get; set; }
    }
}
