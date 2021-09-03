using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ProductReward
    {
        public SaintEir_ProductReward()
        {
            SaintEir_ProductRewardExtras = new HashSet<SaintEir_ProductRewardExtra>();
        }

        public int ProductRewardNo { get; set; }
        public decimal? RewardMoney { get; set; }
        public int? ProductNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public decimal? RewardPercentage { get; set; }
        public int? IsDeCost { get; set; }
        public int? IsDeIntroFee { get; set; }
        public decimal? Cost { get; set; }
        public int? IsDeMaterialCost { get; set; }
        public int? IsUseEstimate { get; set; }
        public int BonusType { get; set; }

        public virtual ICollection<SaintEir_ProductRewardExtra> SaintEir_ProductRewardExtras { get; set; }
    }
}
