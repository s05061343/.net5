using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ReservationLimit
    {
        public int LimitNo { get; set; }
        public string Title { get; set; }
        public int? BasicTime { get; set; }
        public int? MaxCount { get; set; }
        public int? Flag { get; set; }
        public string BelongToBranch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
