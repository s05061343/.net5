using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DailyBalanceItem
    {
        public int BalanceItemNo { get; set; }
        public int? BelongToBalance { get; set; }
        public int? BelongToBalanceSet { get; set; }
        public int? Amount { get; set; }
        public int? Flag { get; set; }
        public string CateroryTitle { get; set; }
        public int? BelongToAccountTitleNo { get; set; }
    }
}
