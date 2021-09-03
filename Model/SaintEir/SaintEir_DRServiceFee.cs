using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DRServiceFee
    {
        public int DRServiceFeeNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public DateTime? ServiceDate { get; set; }
        public decimal? ServiceFee { get; set; }
        public int? Flag { get; set; }
        public string Comment { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
