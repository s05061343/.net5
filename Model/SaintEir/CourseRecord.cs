using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class CourseRecord
    {
        public int CourseRecordNo { get; set; }
        public string BelongToUser { get; set; }
        public int? BelongToCourse { get; set; }
        public DateTime? RecordTime { get; set; }
        public int? Type { get; set; }
        public int? Score { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }
        public string AdvancedComment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
