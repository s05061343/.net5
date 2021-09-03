using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PayStatus
    {
        public int PayStatusNo { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public int? BelongToInProcessService { get; set; }
        public int? BelongToPayHistory { get; set; }
        public int? Flag { get; set; }
    }
}
