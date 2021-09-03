using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_OutPeriod
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Days { get; set; }
        public string Memo { get; set; }
        public int? TakeOffId { get; set; }
        public int? JobAdjustmentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
