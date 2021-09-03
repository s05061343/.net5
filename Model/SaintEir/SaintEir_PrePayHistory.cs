using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PrePayHistory
    {
        public int PrePayHistoryNo { get; set; }
        public int? BelongToMember { get; set; }
        public decimal? PrePayTotalFee { get; set; }
        public string PayWay { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Comment { get; set; }
        public int? Flag { get; set; }
    }
}
