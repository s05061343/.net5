using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_WorkingDayType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string BreakStart { get; set; }
        public string BreakEnd { get; set; }
        public int? BufferMinutes { get; set; }
        public int? OverTimeAllowance { get; set; }
        public int? OverTimeHoursBeforeAllowance { get; set; }
        public string OverTimeStart { get; set; }
        public int? LateMinutesAllowed { get; set; }
        public string EarlyQuitMinutesAllowed { get; set; }
        public int? MinOverTimeMinutes { get; set; }
        public int? OverTimeUnitMinutes { get; set; }
        public int? OverTimeAEndHours { get; set; }
        public int? OverTimeBEndHours { get; set; }
        public int? MaxHour { get; set; }
        public int? En_OverMaxHourOP { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
        public int Is_SPA { get; set; }
    }
}
