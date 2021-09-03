using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecordValue
    {
        public int MedicalRecordValueNo { get; set; }
        public int? BelongToRecord { get; set; }
        public int? BelongToColumn { get; set; }
        public string ItemValue { get; set; }
        public string ItemColumn { get; set; }
        public string ItemRow { get; set; }

        public virtual MedicalRecord BelongToRecordNavigation { get; set; }
    }
}
