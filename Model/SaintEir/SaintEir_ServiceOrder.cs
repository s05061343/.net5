using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ServiceOrder
    {
        public int ServiceOrderNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public string BelongToBranch { get; set; }
        public string BelongToUser { get; set; }
        public int? BelongToRole { get; set; }
        public int? OrderBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
