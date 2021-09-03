using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_EventHistory
    {
        public int EventHistoryNo { get; set; }
        public DateTime? EventDate { get; set; }
        public string Type { get; set; }
        public string BelongToBranch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
