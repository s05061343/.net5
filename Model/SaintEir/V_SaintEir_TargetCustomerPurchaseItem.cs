using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_TargetCustomerPurchaseItem
    {
        public decimal? SoldOutPrice { get; set; }
        public int PurchaseItemNo { get; set; }
        public int? Quantity { get; set; }
        public decimal? ItemFee { get; set; }
        public decimal? SoldOutPrice_Temp { get; set; }
        public int? BelongToCategory { get; set; }
        public int? PurchaseProduct { get; set; }
        public int? PurchasePackage { get; set; }
        public decimal? SellPrice { get; set; }
        public int? PurchaseNo { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string CustomerName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? TotalFee { get; set; }
        public decimal? AlreadyPaid { get; set; }
        public decimal? NotPayYet { get; set; }
        public decimal? ShouldPay { get; set; }
        public int? ByMember { get; set; }
        public string BelongToBranch { get; set; }
        public int? ParentId { get; set; }
        public int? MemberNo { get; set; }
        public DateTime? MemberCreatedDate { get; set; }
        public string AnamnesisNo { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string Sex { get; set; }
        public int? CurrentAge { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile_1 { get; set; }
        public string VIPTAG { get; set; }
        public string WhereToGetInfo { get; set; }
        public string AttendantName { get; set; }
        public string BranchName { get; set; }
        public string BranchNo { get; set; }
        public decimal? GoodsExchangeCredit { get; set; }
        public decimal? GoodsExchangeProductWorth { get; set; }
        public decimal? GoodsRefundCredit { get; set; }
        public decimal? GoodsRefundProductWorth { get; set; }
        public int? packageItemProduct { get; set; }
        public decimal? PackinProductValue { get; set; }
        public int? PackageItemQuantity { get; set; }
    }
}
