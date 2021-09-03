using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecordColumnItem
    {
        public int MedicalRecordColumnItemNo { get; set; }
        public int? BelongToRecordColumn { get; set; }
        public string Item { get; set; }
        public int? OrderBy { get; set; }
        public int? IsSelected { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
