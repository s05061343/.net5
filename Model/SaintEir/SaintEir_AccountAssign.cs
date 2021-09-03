using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AccountAssign
    {
        public int AccountAssignNo { get; set; }
        public int? BelongToInProcessServiceNo { get; set; }
        public decimal? AssignARToIn { get; set; }
        public decimal? AssignARToItemLaser { get; set; }
        public decimal? AssignARToIntravenousDrip { get; set; }
        public decimal? AssignARToItemInjection { get; set; }
        public decimal? AssignARToItemSurgery { get; set; }
        public decimal? AssignARToProduct { get; set; }
        public decimal? AssignARToItemOthers { get; set; }
        public decimal? AssignARToItemSpa { get; set; }
        public decimal? AssignARToCredit { get; set; }
        public decimal? AssignIncomeToItemLaser { get; set; }
        public decimal? AssignIncomeToIntravenousDrip { get; set; }
        public decimal? AssignIncomeToItemInjection { get; set; }
        public decimal? AssignIncomeToItemSurgery { get; set; }
        public decimal? AssignIncomeToItemProduct { get; set; }
        public decimal? AssignIncomeToItemOthers { get; set; }
        public decimal? AssignIncomeToItemSpa { get; set; }
        public decimal? AssignIncomeToCredit { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? AssignARToItemService { get; set; }
        public decimal? AssignIncomeToItemService { get; set; }
    }
}
