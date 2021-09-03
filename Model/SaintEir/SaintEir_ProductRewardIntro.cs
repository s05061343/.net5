using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ProductRewardIntro
    {
        public int ProductRewardIntroNo { get; set; }
        public int? ProductNo { get; set; }
        public int? BelongToIntroducer { get; set; }
        public decimal? RewardPercentage { get; set; }
    }
}
