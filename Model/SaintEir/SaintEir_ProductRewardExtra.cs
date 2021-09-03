using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ProductRewardExtra
    {
        public long ProductRewardExtraNo { get; set; }
        public int ProductRewardNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public string TextExpressionTrait { get; set; }
        public string TextExpressionReward { get; set; }
        public int ExpressionOrder { get; set; }
        public int Flag { get; set; }

        public virtual SaintEir_ProductReward ProductRewardNoNavigation { get; set; }
    }
}
