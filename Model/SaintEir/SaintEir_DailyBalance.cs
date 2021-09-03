using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DailyBalance
    {
        public int BalanceNo { get; set; }
        public DateTime? BalanceDate { get; set; }
        public int IsBalance { get; set; }
        public int? Cash { get; set; }
        public int? FiduciaryLoan { get; set; }
        public int? RemitMoney { get; set; }
        public int? Credit { get; set; }
        public int? CrediteSafe { get; set; }
        public int? InComeFromOther { get; set; }
        public string InComeFromOtherB { get; set; }
        public int? OthersInCome { get; set; }
        public string OthersInComeB { get; set; }
        public int Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? RemitMoney_Product { get; set; }
        public int? CrediteSafe_Product { get; set; }
        public int? Other_Check { get; set; }
        public int? Other_Forex { get; set; }
        public string BelongToBranch { get; set; }
        public string RemitMoneyNote { get; set; }
        public string RemitMoney_ProductNote { get; set; }
        public string FiduciaryLoanNote { get; set; }
    }
}
