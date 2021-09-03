using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_HealthInsuranceVersion
    {
        public SaintEir_HealthInsuranceVersion()
        {
            SaintEir_HealthInsuranceAmounts = new HashSet<SaintEir_HealthInsuranceAmount>();
        }

        public int Id { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Comment { get; set; }
        public int InsType { get; set; }

        public virtual ICollection<SaintEir_HealthInsuranceAmount> SaintEir_HealthInsuranceAmounts { get; set; }
    }
}
