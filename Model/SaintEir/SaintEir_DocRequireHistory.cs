using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DocRequireHistory
    {
        public int DocRequireHistoryNo { get; set; }
        public string Source { get; set; }
        public int? SourceRequire { get; set; }
        public int? Status { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? BelongToConsumptionHistory { get; set; }
        public int? BelongToSignDoc { get; set; }
        public int? BelongToMedicalRecord { get; set; }

        public virtual SaintEir_ComsumptionHistory BelongToConsumptionHistoryNavigation { get; set; }
        public virtual MedicalRecord BelongToMedicalRecordNavigation { get; set; }
        public virtual SaintEir_SignDoc BelongToSignDocNavigation { get; set; }
    }
}
