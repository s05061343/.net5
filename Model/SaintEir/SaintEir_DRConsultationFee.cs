using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DRConsultationFee
    {
        public SaintEir_DRConsultationFee()
        {
            SaintEir_DRConsultationFeeWeekDays = new HashSet<SaintEir_DRConsultationFeeWeekDay>();
        }

        public long DRConsultationFeeNo { get; set; }
        public string BelongToLoginUser { get; set; }
        public decimal Hour { get; set; }
        public decimal Fee { get; set; }
        public decimal UnitWorkTime { get; set; }
        public int Flag { get; set; }
        public string Comment { get; set; }
        public int RewardType { get; set; }
        public decimal ListingFee { get; set; }
        public string ListingBranch { get; set; }
        public int IsWithholdingTaxes { get; set; }
        public int IsRejectWithholdingTaxes { get; set; }
        public int HealthInsuranceLevel { get; set; }
        public int HIVersion { get; set; }
        public string HIBranch { get; set; }
        public int IsHIRationalize { get; set; }
        public string DeanOfBranch { get; set; }
        public int TaxType { get; set; }
        public int TaxBase { get; set; }
        public int DepHealthInsurance { get; set; }
        public int LaborRetirementLevel { get; set; }
        public string LaborRetirementBranch { get; set; }
        public int HIDean { get; set; }

        public virtual ICollection<SaintEir_DRConsultationFeeWeekDay> SaintEir_DRConsultationFeeWeekDays { get; set; }
    }
}
