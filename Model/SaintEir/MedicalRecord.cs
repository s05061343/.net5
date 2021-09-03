using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecord
    {
        public MedicalRecord()
        {
            MedicalRecordRelatives = new HashSet<MedicalRecordRelative>();
            MedicalRecordValues = new HashSet<MedicalRecordValue>();
            SaintEir_DigitalFiles = new HashSet<SaintEir_DigitalFile>();
            SaintEir_DocRequireHistories = new HashSet<SaintEir_DocRequireHistory>();
        }

        public int MedicalRecordNo { get; set; }
        public int? BelongToMember { get; set; }
        public int? BelongToRecordForm { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public string TempIndex { get; set; }
        public int? Status { get; set; }
        public string ByDr { get; set; }
        public string ByFollower { get; set; }
        public string ByNurse { get; set; }
        public string Application { get; set; }

        public virtual ICollection<MedicalRecordRelative> MedicalRecordRelatives { get; set; }
        public virtual ICollection<MedicalRecordValue> MedicalRecordValues { get; set; }
        public virtual ICollection<SaintEir_DigitalFile> SaintEir_DigitalFiles { get; set; }
        public virtual ICollection<SaintEir_DocRequireHistory> SaintEir_DocRequireHistories { get; set; }
    }
}
