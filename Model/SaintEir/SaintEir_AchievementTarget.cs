using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AchievementTarget
    {
        public int AchievementTargetNo { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string BelongToBranch { get; set; }
        public string BelongToUser { get; set; }
        public decimal? Target { get; set; }
        public string BelongToClassify { get; set; }
    }
}
