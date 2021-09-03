using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_EmployeeWorkDay
    {
        public int EmployeeWorkDayNo { get; set; }
        public string BelongToUser { get; set; }
        public DateTime? WorkDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? NumDayOfWeek { get; set; }
        public string DayOfWeek { get; set; }
        public string BelongToBranch { get; set; }
    }
}
