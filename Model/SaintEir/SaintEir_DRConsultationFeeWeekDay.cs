using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DRConsultationFeeWeekDay
    {
        public long DRConsultationFeeWeekDayNo { get; set; }
        public long DRConsultationFeeNo { get; set; }
        public int Weekday { get; set; }
        public decimal MaxWorkTime { get; set; }
        public decimal Fee { get; set; }
        public int Flag { get; set; }

        public virtual SaintEir_DRConsultationFee DRConsultationFeeNoNavigation { get; set; }
    }
}
