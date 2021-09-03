using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Consumable
    {
        public int ConsumableNo { get; set; }
        public int? BelongToMaterial { get; set; }
        public decimal? ConsumableQuantity { get; set; }
        public int? BelongToProduct { get; set; }
        public int? BelongToBHMaterial { get; set; }
        public decimal? BHConsumableQuantity { get; set; }
        public string BelongToBranch { get; set; }
    }
}
