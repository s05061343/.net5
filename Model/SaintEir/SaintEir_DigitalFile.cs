using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DigitalFile
    {
        public int DigitalFileNo { get; set; }
        public string FilePath { get; set; }
        public string UploadFileName { get; set; }
        public int? Flag { get; set; }
        public string Category { get; set; }
        public string Custom { get; set; }
        public string DocTemp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? BelongToSignDoc { get; set; }
        public int? BelongToMedicalRecord { get; set; }

        public virtual MedicalRecord BelongToMedicalRecordNavigation { get; set; }
        public virtual SaintEir_SignDoc BelongToSignDocNavigation { get; set; }
    }
}
