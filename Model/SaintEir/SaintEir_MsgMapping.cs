using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MsgMapping
    {
        public int MsgMappingNo { get; set; }
        public string Type { get; set; }
        public int? BelongToKeyValue { get; set; }
        public int? BelongToSendHistoryNo { get; set; }
        public int? Flag { get; set; }
        public string Main { get; set; }
        public string Addition { get; set; }
    }
}
