using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PackageRewardIntro
    {
        public int PackageRewardIntroNo { get; set; }
        public int? PackageNo { get; set; }
        public int? BelongToIntroducer { get; set; }
        public decimal? RewardPercentage { get; set; }
    }
}
