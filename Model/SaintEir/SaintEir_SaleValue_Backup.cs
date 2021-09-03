using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SaleValue_Backup
    {
        public int SaleValueNo { get; set; }
        public DateTime? ValueDate { get; set; }
        public int? ItemNo { get; set; }
        public int? Type { get; set; }
        public int? ProductSQ { get; set; }
        public decimal? ProductST { get; set; }
        public int? PackageSQ { get; set; }
        public decimal? PackageST { get; set; }
        public int? InProcessNo { get; set; }
        public string PurchaseString { get; set; }
        public int? ConsumptionQuanaity { get; set; }
        public string ConsumptionString { get; set; }
        public string ConsumpitonMember { get; set; }
        public string BelongToBranch { get; set; }
        public int? BelongToMaterial { get; set; }
        public decimal? MaterialStockIn { get; set; }
        public decimal? MaterialStockOut { get; set; }
        public int? ChangeLogNo { get; set; }
    }
}
