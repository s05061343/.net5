using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class IOBARAPTitleMapping
    {
        public int No { get; set; }
        public string BelongTOBranch { get; set; }
        public string ARAP { get; set; }
        public string BelongToTitle { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
