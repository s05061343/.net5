using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class IOBTitleMapping
    {
        public int No { get; set; }
        public string MaterialChangeLogType { get; set; }
        public string BelongToBranch { get; set; }
        public int? Status { get; set; }
        public int? IsMaterial { get; set; }
        public string BelongToTitle { get; set; }
        public string PriceType { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
