using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BalanceSheet
    {
        public int BalanceSheetNo { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? dateTime { get; set; }
        public decimal? Cash { get; set; }
        public decimal? PettyCash { get; set; }
        public decimal? CashInBanks { get; set; }
        public decimal? NotesReceivable { get; set; }
        public decimal? AccountsReceivable { get; set; }
        public decimal? PrepaidExpenses { get; set; }
        public decimal? PrepaymentsToSuppliers { get; set; }
        public decimal? Inventories { get; set; }
        public decimal? Temporaryhan { get; set; }
        public decimal? TemporarySaintSin { get; set; }
        public decimal? GuaranteeDepositsPaid { get; set; }
        public decimal? ShareholderAccounts { get; set; }
        public decimal? Land { get; set; }
        public decimal? Buildings { get; set; }
        public decimal? DeBuildings { get; set; }
        public decimal? Machinery { get; set; }
        public decimal? DeMachinery { get; set; }
        public decimal? Transportation { get; set; }
        public decimal? DeTransportation { get; set; }
        public decimal? OtherFixedAssets { get; set; }
        public decimal? DeOtherFixedAssets { get; set; }
        public decimal? DueToBanks { get; set; }
        public decimal? NotesPayable { get; set; }
        public decimal? AccountsPayable { get; set; }
        public decimal? AccruedExpenses { get; set; }
        public decimal? OtherAccruedExpenses { get; set; }
        public decimal? OtherAdvanceReceiptsSalary { get; set; }
        public decimal? CapitalStock { get; set; }
        public decimal? AccumulatedProfitAndLoss { get; set; }
        public decimal? CurrentProfitAndLoss { get; set; }
    }
}
