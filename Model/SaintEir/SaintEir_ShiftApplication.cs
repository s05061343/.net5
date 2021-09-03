using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ShiftApplication
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public string UserId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Memo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
