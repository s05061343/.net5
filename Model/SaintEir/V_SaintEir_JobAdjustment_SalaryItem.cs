using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_JobAdjustment_SalaryItem
    {
        public int Id { get; set; }
        public int AdjustmentId { get; set; }
        public int ItemId { get; set; }
        public int OldValue { get; set; }
        public int NewValue { get; set; }
        public string Name { get; set; }
        public int? En_Type { get; set; }
        public string Code { get; set; }
    }
}
