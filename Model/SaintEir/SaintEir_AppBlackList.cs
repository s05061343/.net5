using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AppBlackList
    {
        public int BlackListNo { get; set; }
        public int? Type { get; set; }
        public string KeyValue { get; set; }
        public int? Flag { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Reason { get; set; }
    }
}
