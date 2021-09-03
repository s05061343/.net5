using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ActivityGood
    {
        public int ActivityGoodsNo { get; set; }
        public int? BelongProductKeyNo { get; set; }
        public string ProductName { get; set; }
        public int? BelongActivityNo { get; set; }
        public decimal? Price { get; set; }
        public bool? isGift { get; set; }
        public int? Quantity { get; set; }
        public string Note { get; set; }
        public string ProductOrPackage { get; set; }
        public int? Flag { get; set; }
    }
}
