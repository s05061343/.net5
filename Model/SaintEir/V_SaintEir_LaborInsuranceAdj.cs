using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_LaborInsuranceAdj
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int En_Type { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int? Salary { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatorId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeleterId { get; set; }
        public string FullNameInChinese { get; set; }
        public string CreatorName { get; set; }
        public int? IsAlive { get; set; }
        public int? p_EmployeeStatus { get; set; }
        public int? Version { get; set; }
        public string DepartmentName { get; set; }
    }
}
