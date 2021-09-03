using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Reservation
    {
        public SaintEir_Reservation()
        {
            SaintEir_Achievements = new HashSet<SaintEir_Achievement>();
        }

        public int ReservationNo { get; set; }
        public string CustomerName { get; set; }
        public string Mobile { get; set; }
        public string Detail { get; set; }
        public string ByDr { get; set; }
        public string ByNurceA { get; set; }
        public string ByNurceB { get; set; }
        public string ByConsult { get; set; }
        public string ByResource { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string OperationItemNo { get; set; }
        public int? Flag { get; set; }
        public string BelongToBranch { get; set; }
        public string MemberNo { get; set; }
        public string CancelReason { get; set; }
        public int? IsOnlie { get; set; }
        public int? FollowOn { get; set; }
        public string Comment { get; set; }
        public int? LeadTime { get; set; }
        public int? CureTime { get; set; }
        public int? IsReserved { get; set; }
        public string IsReserved3 { get; set; }
        public string ReservationType { get; set; }
        public string CustomerType { get; set; }
        public int? EntryType { get; set; }
        public string EntryType3 { get; set; }
        public int? ReservationStatus { get; set; }
        public int? IsArrived { get; set; }
        public string EventBackColor { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ReminderDate { get; set; }
        public int? ReminderStatus { get; set; }
        public string ReminderComment { get; set; }
        public string Beautician { get; set; }
        public int? IsRemindComplete { get; set; }
        public string RemindCompleteUser { get; set; }
        public DateTime? RemindCompleteDate { get; set; }
        public int? RelationNo { get; set; }
        public string Birthday { get; set; }
        public string Attendant { get; set; }
        public int? IsConsultByTurn { get; set; }
        public int IsConflict { get; set; }

        public virtual ICollection<SaintEir_Achievement> SaintEir_Achievements { get; set; }
    }
}
