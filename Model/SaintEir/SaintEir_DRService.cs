using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DRService
    {
        public int DRServiceNo { get; set; }
        public string BelongToBranch { get; set; }
        public string BelongToLoginUser { get; set; }
        public DateTime? ServiceDate { get; set; }
        public decimal? ServiceCount { get; set; }
        public decimal? ServiceFee { get; set; }
        public decimal? TotalServiceFee { get; set; }
        public int? Flag { get; set; }
        public string Comment { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal? WorkTime { get; set; }
        public DateTime? OnDutyTime { get; set; }
        public DateTime? OffDutyTime { get; set; }
        public string OnDutyTimeUpdatedBy { get; set; }
        public string OffDutyTimeUpdatedBy { get; set; }
        public DateTime? ReviseOnDutyTime { get; set; }
        public DateTime? ReviseOffDutyTime { get; set; }
        public string ReviseOnDutyTimeUpdatedBy { get; set; }
        public string ReviseOffDutyTimeUpdatedBy { get; set; }
        public string Expression { get; set; }
        public int Lock { get; set; }
        public int IsRation { get; set; }
        public DateTime? FeeOffDutyTime { get; set; }
        public int DutyType { get; set; }
        public DateTime? RationDate { get; set; }
        public int RationFlag { get; set; }
    }
}
