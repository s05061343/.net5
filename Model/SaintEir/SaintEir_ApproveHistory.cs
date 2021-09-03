using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ApproveHistory
    {
        public int ApproveHistoryNo { get; set; }
        public int? Flag { get; set; }
        public string Comment { get; set; }
        public int? BelongToEvent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
