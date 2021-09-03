using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BranchOrderSet
    {
        public int BranchOrderSetNo { get; set; }
        public string BelongToBranch { get; set; }
        public int? TransitTime { get; set; }
        public int? OrderDay { get; set; }
    }
}
