using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Declare
    {
        public int DeclareNo { get; set; }
        public string DeclareContent { get; set; }
        public int? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreatedBy { get; set; }
        public string ToLoginUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public string BelongToBranch { get; set; }
        public string DeclareTitle { get; set; }
        public int? DeclareCategory { get; set; }
        public int? DeclareDepartment { get; set; }
        public string ToDepartment { get; set; }
        public string ToJobTitle { get; set; }
    }
}
