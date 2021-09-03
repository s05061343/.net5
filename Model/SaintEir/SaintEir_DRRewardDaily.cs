using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DRRewardDaily
    {
        public long DRRewardDailyNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public DateTime Date { get; set; }
        public decimal ConsultationFee { get; set; }
        public decimal Bonus { get; set; }
        public decimal Result { get; set; }
        public int Lock { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? RationDate { get; set; }
        public int RationFlag { get; set; }
    }
}
