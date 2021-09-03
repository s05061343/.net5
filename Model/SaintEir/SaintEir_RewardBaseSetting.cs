using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_RewardBaseSetting
    {
        public long RewardBaseSettingNo { get; set; }
        public long ProductNo { get; set; }
        public int RoleType { get; set; }
        public int TradeType { get; set; }
        public decimal RewardBase { get; set; }
    }
}
