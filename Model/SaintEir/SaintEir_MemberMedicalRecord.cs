using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MemberMedicalRecord
    {
        public SaintEir_MemberMedicalRecord()
        {
            MedicalRecordRelatives = new HashSet<MedicalRecordRelative>();
        }

        public int MedicalRecordNo { get; set; }
        public int? BelongToConsumption { get; set; }
        public string Content { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? Flag { get; set; }
        public int? Status { get; set; }
        public int? BelongToMember { get; set; }
        public int? BelongToReservation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<MedicalRecordRelative> MedicalRecordRelatives { get; set; }
    }
}
