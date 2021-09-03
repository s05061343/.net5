using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_InsuranceIdentity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? LINormalAccidentRate { get; set; }
        public decimal? LINAInsuredPercentage { get; set; }
        public decimal? LINACompanyPercentage { get; set; }
        public decimal? LIEmploymentRate { get; set; }
        public decimal? LIEInsuredPercentage { get; set; }
        public decimal? LIECompanyPercentage { get; set; }
        public decimal? LIOccupationalHazardRate { get; set; }
        public decimal? LIOHInsuredPercentage { get; set; }
        public decimal? LIOHCompanyPercentage { get; set; }
        public decimal? LIWageCompensationFund { get; set; }
        public decimal? LIWCFInsuredPercentage { get; set; }
        public decimal? LIWCFCompanyPercentage { get; set; }
        public decimal? HIRate { get; set; }
        public decimal? HIInsuredPercentage { get; set; }
        public decimal? HICompanyPercentage { get; set; }
        public string Memo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
