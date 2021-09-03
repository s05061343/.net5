using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SupplyList
    {
        public int SupplyListNo { get; set; }
        public int? BelongToSupplier { get; set; }
        public int? BelongToProduct { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Comment { get; set; }
        public int? Flag { get; set; }
    }
}
