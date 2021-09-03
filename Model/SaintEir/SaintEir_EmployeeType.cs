using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_EmployeeType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public string Memo { get; set; }
        public int Is_StartLastMonth { get; set; }
        public int StartDay { get; set; }
        public int Is_EndLastMonth { get; set; }
        public int EndDay { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
