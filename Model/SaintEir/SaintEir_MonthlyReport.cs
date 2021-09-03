using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MonthlyReport
    {
        public int MonthlyReportNo { get; set; }
        public DateTime? dateTime { get; set; }
        public decimal? SumIn { get; set; }
        public decimal? ItemLaser { get; set; }
        public decimal? RealItemLaser { get; set; }
        public decimal? IntravenousDrip { get; set; }
        public decimal? RealIntravenousDrip { get; set; }
        public decimal? ItemInjection { get; set; }
        public decimal? RealItemInjection { get; set; }
        public decimal? ItemSurgery { get; set; }
        public decimal? RealItemSurgery { get; set; }
        public decimal? SumItem { get; set; }
        public decimal? SumProduct { get; set; }
        public decimal? RealSumProduct { get; set; }
        public decimal? RealSumCredit { get; set; }
        public decimal? SumCredit { get; set; }
        public decimal? RealSumSpa { get; set; }
        public decimal? SumSpa { get; set; }
        public decimal? SumLeftPay { get; set; }
        public decimal? SumVirtualIncome { get; set; }
        public decimal? SumCashIn { get; set; }
        public decimal? SumCreditIn { get; set; }
        public decimal? SumRealAmount { get; set; }
        public decimal? SumNotPayYet { get; set; }
        public decimal? RemainAR { get; set; }
        public decimal? SumDayAmount { get; set; }
        public decimal? SumTaxIn { get; set; }
        public string BelongToBranch { get; set; }
        public decimal? RealItemService { get; set; }
        public decimal? ItemService { get; set; }
    }
}
