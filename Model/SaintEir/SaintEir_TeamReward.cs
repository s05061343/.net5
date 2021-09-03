using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TeamReward
    {
        public int TeamRewardNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public int? BelongToIntroducer { get; set; }
        public decimal? RewardPercentage { get; set; }
        public decimal? RewardMoney { get; set; }
        public decimal? RangeStart { get; set; }
        public decimal? RangeEnd { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
