using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class Course
    {
        public int CourseNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? BelongToCategory { get; set; }
        public int? ExamRequired { get; set; }
        public string ExamExpired { get; set; }
        public int? OrderBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
