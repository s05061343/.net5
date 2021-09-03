using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecordRelative
    {
        public int MedicalRecordRelativeNo { get; set; }
        public int? BelongToMedicalRecord { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string TempIndex { get; set; }
        public int? BelongToPurchaseItem { get; set; }
        public int? BelongToConsumptionHistory { get; set; }
        public int? BelongToConsultation { get; set; }

        public virtual SaintEir_MemberMedicalRecord BelongToConsultationNavigation { get; set; }
        public virtual SaintEir_ComsumptionHistory BelongToConsumptionHistoryNavigation { get; set; }
        public virtual MedicalRecord BelongToMedicalRecordNavigation { get; set; }
        public virtual SaintEir_PurchaseItem BelongToPurchaseItemNavigation { get; set; }
    }
}
