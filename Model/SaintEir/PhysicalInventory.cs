using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PhysicalInventory
    {
        public int PhysicalInventoryNo { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? InventoryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? InBoundNo { get; set; }
        public int? OutBoundNo { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? ToIOBDate { get; set; }
        public string ToIOBBy { get; set; }
        public int? Flag { get; set; }
        public string InventoryHelper1 { get; set; }
        public string InventoryHelper2 { get; set; }
    }
}
