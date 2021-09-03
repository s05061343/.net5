using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TakeOffType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public int UnitMinute { get; set; }
        public int Is_UpdateClockRecord { get; set; }
        public int MaxMiunte { get; set; }
        public int MaxtimesPerMonth { get; set; }
        public int DebitSalaryPercentage { get; set; }
        public int NoAttendanceBonusAfterTimes { get; set; }
        public int? p_AdditionalLeaveType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
        public int Is_Agent { get; set; }
        public int Is_DeductSeniority { get; set; }
        public int Is_IncludeHoliday { get; set; }
        public int Is_NoUse { get; set; }
    }
}
