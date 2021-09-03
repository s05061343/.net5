using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_RewardPaidItem
    {
        public int RewardPaidItemKeyNo { get; set; }
        public int? BelongToRewardPaid { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public decimal? PaidAmount { get; set; }
    }
}
