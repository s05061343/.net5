using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AttendantFaultVersion
    {
        public SaintEir_AttendantFaultVersion()
        {
            SaintEir_AttendantFaultRules = new HashSet<SaintEir_AttendantFaultRule>();
        }

        public long ID { get; set; }
        public string VersionName { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual ICollection<SaintEir_AttendantFaultRule> SaintEir_AttendantFaultRules { get; set; }
    }
}
