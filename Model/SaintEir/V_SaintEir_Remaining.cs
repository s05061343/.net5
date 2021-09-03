using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_Remaining
    {
        public int RemainingNo { get; set; }
        public int ProductKeyNo { get; set; }
        public string NameInChinese { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public string FullName { get; set; }
        public string AnamnesisNo { get; set; }
        public decimal? ItemFee { get; set; }
        public string BelongToBranch { get; set; }
    }
}
