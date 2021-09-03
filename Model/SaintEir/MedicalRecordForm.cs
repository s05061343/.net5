using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecordForm
    {
        public int MedicalRecordFormNo { get; set; }
        public string Title { get; set; }
        public int? BelongToMenuPath { get; set; }
        public int? OrderBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public int? ClinicDepartment { get; set; }
        public string Category { get; set; }
        public int? RecordDisplay { get; set; }
        public int? Type { get; set; }
    }
}
