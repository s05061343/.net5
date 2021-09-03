using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Introducer
    {
        public int IntroducerKeyNo { get; set; }
        public string IntroducerNo { get; set; }
        public string FullName { get; set; }
        public string SSID { get; set; }
        public string Birthday { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel_H_AreaCode { get; set; }
        public string Tel_H_Number { get; set; }
        public string Mobile_1 { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CompanyName { get; set; }
        public string SalesBy { get; set; }
        public int? BelongToIntroducer { get; set; }
        public string BankAccount { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
    }
}
