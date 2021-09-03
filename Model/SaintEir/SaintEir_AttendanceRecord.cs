using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AttendanceRecord
    {
        public int Id { get; set; }
        public DateTime YMD { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? WorkingDayTypeId { get; set; }
        public string WorkingDayTypeCode { get; set; }
        public string WorkingDayTypeName { get; set; }
        public DateTime? WorkingDayStart { get; set; }
        public DateTime? WorkingDayEnd { get; set; }
        public int? WorkingDayHour { get; set; }
        public DateTime? WorkingDayOvertimeStart { get; set; }
        public string CardNo { get; set; }
        public DateTime? ImportFirst { get; set; }
        public DateTime? ImportLast { get; set; }
        public DateTime? AdjFirst { get; set; }
        public DateTime? AdjLast { get; set; }
        public DateTime? FinalFirst { get; set; }
        public DateTime? FinalLast { get; set; }
        public DateTime? ImportOvertimeStart { get; set; }
        public DateTime? ImportOvertimeEnd { get; set; }
        public DateTime? AdjOvertimeStart { get; set; }
        public DateTime? AdjOvertimeEnd { get; set; }
        public DateTime? FinalOvertimeStart { get; set; }
        public DateTime? FinalOvertimeEnd { get; set; }
        public int LateMinutes { get; set; }
        public int EarlyMinutes { get; set; }
        public int OverTimeMinutes { get; set; }
        public int? Is_OK { get; set; }
        public string AttendanceStatus { get; set; }
        public string DealStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string AdjUserId { get; set; }
        public DateTime? AdjDate { get; set; }
        public int TakeOffAppMinutes { get; set; }
        public int OvertimeAppMinutes { get; set; }
        public int ApprovedTakeOffAppMinutes { get; set; }
        public int ApprovedOvertimeAppMinutes { get; set; }
    }
}
