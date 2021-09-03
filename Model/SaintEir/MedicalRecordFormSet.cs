using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecordFormSet
    {
        public int MedicalRecordFormSetNo { get; set; }
        public int? BelongToRecordForm { get; set; }
        public int? BelongToProduct { get; set; }
        public int? Require { get; set; }
    }
}
