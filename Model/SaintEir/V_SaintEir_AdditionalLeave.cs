using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_AdditionalLeave
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int p_AdditionalLeaveType { get; set; }
        public int SourceId { get; set; }
        public decimal Hours { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal UsedHours { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string DepartmentName { get; set; }
        public string FullNameInChinese { get; set; }
        public string DepartmentCode { get; set; }
        public string TypeName { get; set; }
        public string Memo { get; set; }
        public int? DepartmentId { get; set; }
        public string Email { get; set; }
        public string DocNo { get; set; }
        public int? p_EmployeeStatus { get; set; }
        public int ToSalaryAmount { get; set; }
        public DateTime? ToSalaryDate { get; set; }
    }
}
