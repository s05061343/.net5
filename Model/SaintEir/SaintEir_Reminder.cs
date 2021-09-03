using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Reminder
    {
        public int ReminderNo { get; set; }
        public string ReminderType { get; set; }
        public int? BelongToRemindParamNo { get; set; }
        public int? MemberNo { get; set; }
        public DateTime? RemindDate { get; set; }
        public DateTime? EarlyRemindDate { get; set; }
        public int? BelongToConsumptionHistoryNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? ReminderStatus { get; set; }
        public string RemindUser { get; set; }
        public int? RemindPostponed { get; set; }
        public int? Signature { get; set; }
        public DateTime? SignedDate { get; set; }
        public string SignedBy { get; set; }
    }
}
