using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TakeOffApplication
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public string UserId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime ArriveDate { get; set; }
        public int Seniority_Month { get; set; }
        public string DeputyId { get; set; }
        public string DeputyName { get; set; }
        public int? DeputyDepartmentId { get; set; }
        public string DeputyDepartmentName { get; set; }
        public int TakeOffTypeId { get; set; }
        public string TakeOffTypeName { get; set; }
        public int TakeOffUnit_Minute { get; set; }
        public int TotalUnit { get; set; }
        public int TotalMinutes { get; set; }
        public decimal TotalHour { get; set; }
        public decimal TotalDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DeductionDay { get; set; }
        public string Memo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
