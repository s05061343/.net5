using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PhysicalInventoryItem
    {
        public int PhysicalInventoryItemNo { get; set; }
        public int? BelongToPhysicalInventory { get; set; }
        public int? BelongToBHMaterial { get; set; }
        public decimal? PresentQuantity { get; set; }
        public decimal? InventoryQuantity { get; set; }
        public string Comment { get; set; }
    }
}
