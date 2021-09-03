using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PersonalReward
    {
        public int PersonalRewardNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public int? BelongToIntroducer { get; set; }
        public string ClassifySetName { get; set; }
        public string ClassifySet { get; set; }
        public decimal? RewardPercentage { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
