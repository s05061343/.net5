using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_HealthInsuranceAmount
    {
        public int Id { get; set; }
        public int InsLevel { get; set; }
        public int InsAmt { get; set; }
        public int Personal { get; set; }
        public int Dependents1 { get; set; }
        public int Dependents2 { get; set; }
        public int Dependents3 { get; set; }
        public int Company { get; set; }
        public int Government { get; set; }
        public int Version { get; set; }

        public virtual SaintEir_HealthInsuranceVersion VersionNavigation { get; set; }
    }
}
