using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Purchase
    {
        public SaintEir_Purchase()
        {
            SaintEir_ComsumptionHistories = new HashSet<SaintEir_ComsumptionHistory>();
            SaintEir_PayHistories = new HashSet<SaintEir_PayHistory>();
            SaintEir_PurchaseItems = new HashSet<SaintEir_PurchaseItem>();
        }

        public int PurchaseNo { get; set; }
        public string IncomeNo { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string SoldBy { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal? TotalFee { get; set; }
        public decimal? AlreadyPaid { get; set; }
        public decimal? NotPayYet { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? ShouldPay { get; set; }
        public string Comment { get; set; }
        public int? Flag { get; set; }
        public int? IsCompleted { get; set; }
        public int? IsProductUsedCompeted { get; set; }
        public int? ByMember { get; set; }
        public int? BelongToInProcess { get; set; }
        public string ANo { get; set; }
        public string BelongToBranch { get; set; }
        public decimal? SellPrice { get; set; }

        public virtual PRO2E_AUTH_LOGIN_USER SoldByNavigation { get; set; }
        public virtual ICollection<SaintEir_ComsumptionHistory> SaintEir_ComsumptionHistories { get; set; }
        public virtual ICollection<SaintEir_PayHistory> SaintEir_PayHistories { get; set; }
        public virtual ICollection<SaintEir_PurchaseItem> SaintEir_PurchaseItems { get; set; }
    }
}
