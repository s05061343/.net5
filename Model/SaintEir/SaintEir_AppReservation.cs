using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AppReservation
    {
        public int ReservationNo { get; set; }
        public DateTime? ResDate { get; set; }
        public string ResTime { get; set; }
        public DateTime? EndDate { get; set; }
        public string CustomerName { get; set; }
        public string Mobile { get; set; }
        public int? MemberNo { get; set; }
        public string Detail { get; set; }
        public string ByDr { get; set; }
        public string BelongToBranch { get; set; }
        public string CancelReason { get; set; }
        public int? Flag { get; set; }
        public int? ReservationType { get; set; }
        public int? ReservationStatus { get; set; }
        public int? BelongToReservation { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Token { get; set; }
        public string Comment { get; set; }
    }
}
