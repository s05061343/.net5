using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BHMaterialChangeLog
    {
        public int ChangeLogNo { get; set; }
        public int? BelongToMaterial { get; set; }
        public decimal? ChangeQuantity { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public int? Stage { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
