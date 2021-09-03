using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CashFlowMapping
    {
        public int CashFlowMappingNo { get; set; }
        public int? BelongToTitle { get; set; }
        public int? IsCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
