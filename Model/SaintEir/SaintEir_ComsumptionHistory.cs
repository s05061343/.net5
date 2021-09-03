using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ComsumptionHistory
    {
        public SaintEir_ComsumptionHistory()
        {
            MedicalRecordRelatives = new HashSet<MedicalRecordRelative>();
            SaintEir_DocRequireHistories = new HashSet<SaintEir_DocRequireHistory>();
            SaintEir_SignDocRelatives = new HashSet<SaintEir_SignDocRelative>();
        }

        public int ConsumptionHistoryNo { get; set; }
        public int? Quantity { get; set; }
        public DateTime? ConsumptionDate { get; set; }
        public string CreatedBy { get; set; }
        public string Comment { get; set; }
        public int? Flag { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public int? BelongToInProcessService { get; set; }
        public int? ConsumptionProduct { get; set; }
        public string ByDr { get; set; }
        public string ByFollowerA { get; set; }
        public string ByFollowerB { get; set; }
        public string ByChecker { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public decimal? UseUnit { get; set; }
        public int? IsUpdateToMaterial { get; set; }
        public int? ConsumptionType { get; set; }
        public decimal? SAamount { get; set; }
        public int? RemainingNo { get; set; }
        public string BelongToBranch { get; set; }
        public string ByReminderA { get; set; }
        public string ByReminderB { get; set; }
        public int? Signature { get; set; }

        public virtual SaintEir_Purchase BelongToPurchaseNavigation { get; set; }
        public virtual ICollection<MedicalRecordRelative> MedicalRecordRelatives { get; set; }
        public virtual ICollection<SaintEir_DocRequireHistory> SaintEir_DocRequireHistories { get; set; }
        public virtual ICollection<SaintEir_SignDocRelative> SaintEir_SignDocRelatives { get; set; }
    }
}
