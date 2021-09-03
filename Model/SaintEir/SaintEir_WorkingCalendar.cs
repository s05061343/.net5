using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_WorkingCalendar
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int CalendarId { get; set; }
        public string Memo { get; set; }
        public int? WorkingDayType0 { get; set; }
        public int? WorkingDayType1 { get; set; }
        public int? WorkingDayType2 { get; set; }
        public int? WorkingDayType3 { get; set; }
        public int? WorkingDayType4 { get; set; }
        public int? WorkingDayType5 { get; set; }
        public int? WorkingDayType6 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
