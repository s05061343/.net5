using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_SalesInformation_productinPackage
    {
        public DateTime? 購買日期 { get; set; }
        public int? ProductKeyNo { get; set; }
        public string 產品名稱 { get; set; }
        public string 會員姓名 { get; set; }
        public string 服務人員AttendantName { get; set; }
        public DateTime? 建立日期CreateDate { get; set; }
        public int? MemberNo { get; set; }
        public decimal? SellPrice { get; set; }
        public decimal? ItemFee { get; set; }
        public decimal? SoldOutPrice { get; set; }
        public int? 購買數量PurchaseQuantity { get; set; }
        public int? 套餐數量ItemQuantity { get; set; }
        public decimal? TotalUnit { get; set; }
        public decimal? StatisticUnit { get; set; }
        public string 館別代號 { get; set; }
        public int? packageItemProduct { get; set; }
    }
}
