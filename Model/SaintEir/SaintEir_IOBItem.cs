using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_IOBItem
    {
        public int IOBItemNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? SubTotal { get; set; }
        public int? BelongToSupplier { get; set; }
        public int? BelongToMaterial { get; set; }
        public int? BelongToIOB { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public int? Flag { get; set; }
        public decimal? UnitCost { get; set; }
        public int? BelongToMaterialConsumption { get; set; }
    }
}
