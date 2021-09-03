using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_InProcessService
    {
        public int InProcessServiceNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsOnline { get; set; }
        public string PurchaseObject { get; set; }
        public string ConsumptionObject { get; set; }
        public string PurchasedThisTimeItemsObject { get; set; }
        public string PurchasedItemsObject { get; set; }
        public string Commant { get; set; }
        public string CreatedBy { get; set; }
        public int? ByMember { get; set; }
        public string ServeBy { get; set; }
        public int? IsCheck { get; set; }
        public int? ByIntroducer { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ServeBy2 { get; set; }
        public string AuthCode { get; set; }
        public string AuthBy { get; set; }
        public DateTime? AuthLimitDate { get; set; }
        public string AuthReason { get; set; }
        public int? AuthStatus { get; set; }
        public DateTime? AuthDate { get; set; }
        public string Status { get; set; }
        public int? BelongToCategory { get; set; }
        public string BelongToDoctor { get; set; }
        public string Memo { get; set; }
        public int? IsReserved { get; set; }
        public int? BelongToReservation { get; set; }
        public int? BelongToSignature { get; set; }

        public virtual SaintEir_Signature BelongToSignatureNavigation { get; set; }
        public virtual SaintEir_Member ByMemberNavigation { get; set; }
    }
}
