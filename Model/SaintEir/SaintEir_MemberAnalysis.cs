using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MemberAnalysis
    {
        public int MemberAnalysisNo { get; set; }
        public int? BelongToMember { get; set; }
        public int? RValue { get; set; }
        public int? FValue { get; set; }
        public int? MValue { get; set; }
    }
}
