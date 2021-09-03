using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_WorkingTime
    {
        public int WorkingTimeNo { get; set; }
        public DateTime? WorkDate { get; set; }
        public int? TimeFrom { get; set; }
        public int? TimeTo { get; set; }
        public int? IsAvailable { get; set; }
        public int? IsRoutine { get; set; }
        public string InWeekDays { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string BelongToLoginUserId { get; set; }
        public string BelongToBranch { get; set; }
    }
}
