using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CallHistory
    {
        public int CallHistoryNo { get; set; }
        public int? Satisfaction { get; set; }
        public DateTime? CallDate { get; set; }
        public string CallContent { get; set; }
        public string TreatmentType { get; set; }
        public int? Flag { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? BelongToMember { get; set; }
        public string BelongToAttendant { get; set; }

        public virtual PRO2E_AUTH_LOGIN_USER BelongToAttendantNavigation { get; set; }
        public virtual SaintEir_Member BelongToMemberNavigation { get; set; }
    }
}
