using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DBSetting
    {
        public int DBSNo { get; set; }
        public string KeyValue { get; set; }
        public string BelongToBranch { get; set; }
        public int? AccountTitleNo { get; set; }
        public int? Status { get; set; }
        public string CategoryTitle { get; set; }
    }
}
