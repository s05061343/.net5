using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PurchaseItemSubTotal
    {
        public int PurchaseItemSubTotalNo { get; set; }
        public string ItemNo { get; set; }
        public int? PurchaseProduct { get; set; }
        public int? PurchasePackage { get; set; }
        public int? SubTotal { get; set; }
        public DateTime? BelongDate { get; set; }
        public decimal? SoldOutPrice { get; set; }
        public string BelongToBranch { get; set; }
    }
}
