using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AdvisoryHistory
    {
        public int AdvisoryHistoryNo { get; set; }
        public string BelongToAdvisoryEvent { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Content { get; set; }
        public string BelongToAdvisoryHistory { get; set; }
        public string CreatedBy { get; set; }
    }
}
