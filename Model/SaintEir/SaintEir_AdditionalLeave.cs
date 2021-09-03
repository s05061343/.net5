using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AdditionalLeave
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
        public string Memo { get; set; }
        public string IsToSalary { get; set; }
        public int ToSalaryAmount { get; set; }
        public DateTime? ToSalaryDate { get; set; }
    }
}
