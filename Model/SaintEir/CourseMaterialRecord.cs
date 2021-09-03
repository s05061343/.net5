using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class CourseMaterialRecord
    {
        public int CourseMaterialRecordNo { get; set; }
        public string BelongToUser { get; set; }
        public int? BelongToMaterial { get; set; }
        public DateTime? RecordTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
