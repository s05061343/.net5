using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ProductOrderItem
    {
        public int ProductOrderItemNo { get; set; }
        public int? ProductKeyNo { get; set; }
        public decimal? Quantity { get; set; }
        public string BelongToProductOrder { get; set; }
        public int? OrderMaterial { get; set; }
        public int? BelongToSupplier { get; set; }
        public int? ApplyMaterial { get; set; }
        public decimal? ApplyQuantity { get; set; }
        public decimal? AcceptQuantity { get; set; }
        public int Flag { get; set; }
    }
}
