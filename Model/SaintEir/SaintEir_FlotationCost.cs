using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_FlotationCost
    {
        public int FlotationCostsNo { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public decimal? FlotationCostsAmount { get; set; }
    }
}
