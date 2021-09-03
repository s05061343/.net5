using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class CourseResult
    {
        public int CourseResultNo { get; set; }
        public string BelongToUser { get; set; }
        public int? BelongToCourse { get; set; }
        public int? Type { get; set; }
        public string Result { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
