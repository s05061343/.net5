using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_JobAdjustment_SalaryItem
    {
        public int Id { get; set; }
        public int AdjustmentId { get; set; }
        public int ItemId { get; set; }
        public int OldValue { get; set; }
        public int NewValue { get; set; }
        public DateTime? OldStartDate { get; set; }
        public DateTime? NewStartDate { get; set; }
        public DateTime? OldEndDate { get; set; }
        public DateTime? NewEndDate { get; set; }
    }
}
