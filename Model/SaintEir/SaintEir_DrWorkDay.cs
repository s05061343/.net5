using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DrWorkDay
    {
        public int DrWorkDayNo { get; set; }
        public string BelongToUser { get; set; }
        public int? Week { get; set; }
        public string DayOfWeek { get; set; }
        public int? NumDayOfWeek { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public string BelongToBranch { get; set; }
    }
}
