using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_InComeAssign
    {
        public int AssignNo { get; set; }
        public int? BelongToInProcess { get; set; }
        public int? BelongToCategory { get; set; }
        public decimal? AssignInCome { get; set; }
        public decimal? AssignAR { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
