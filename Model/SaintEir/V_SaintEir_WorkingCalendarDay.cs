using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_WorkingCalendarDay
    {
        public int Id { get; set; }
        public int CalendarId { get; set; }
        public int Year { get; set; }
        public DateTime Day { get; set; }
        public int Is_Off { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string HolidayName { get; set; }
        public int? WorkingDayTypeId { get; set; }
        public string WorkingDayTypeName { get; set; }
        public int WeekDay { get; set; }
        public string WorkingDayTypeCode { get; set; }
    }
}
