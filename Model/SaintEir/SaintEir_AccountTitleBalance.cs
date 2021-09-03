using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AccountTitleBalance
    {
        public int AccountTitleBalanceNO { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? dateTime { get; set; }
        public int? BelongToAccountTitle { get; set; }
        public int? Amount { get; set; }
    }
}
