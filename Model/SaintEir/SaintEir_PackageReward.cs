using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PackageReward
    {
        public int PackageRewardNo { get; set; }
        public int? PackageNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public decimal? RewardPercentage { get; set; }
        public int? IsDeIntroFee { get; set; }
    }
}
