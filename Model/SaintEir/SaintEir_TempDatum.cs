using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TempDatum
    {
        public int TempDataNo { get; set; }
        public string SessionId { get; set; }
        public int? KeyValue { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
