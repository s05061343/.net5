using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CalendarDay
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
        public int WeekDay { get; set; }
    }
}
