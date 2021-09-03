using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_Department
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public string Memo { get; set; }
        public int? UpDepartmentId { get; set; }
        public string ManagerId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string ManagerName { get; set; }
        public string UpDepartmentName { get; set; }
        public int Flag { get; set; }
        public string LevelCode { get; set; }
        public string LockedYM { get; set; }
        public int p_ScheduleType { get; set; }
        public string ScheduleTypeName { get; set; }
        public string Is_BirthdayBonus { get; set; }
        public string Is_CashSalary { get; set; }
        public int DepartmentAnnualLeaveType { get; set; }
    }
}
