using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_LaborInsuranceAdj
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
        public string Memo { get; set; }
        public string InsuranceDepartment { get; set; }
    }
}
