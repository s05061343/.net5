using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ServiceControl
    {
        public int ServiceControlNo { get; set; }
        public int? CheckInSerialNo { get; set; }
        public int? BelongToReservation { get; set; }
        public string BelongToBranch { get; set; }
        public int? ServiceClassify { get; set; }
        public string Attendant { get; set; }
        public string Comment { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string BelongToDoctor { get; set; }
        public int? BelongToMember { get; set; }
        public DateTime? StartingTime { get; set; }
    }
}
