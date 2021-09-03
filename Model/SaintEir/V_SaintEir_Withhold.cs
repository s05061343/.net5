using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_Withhold
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public string StartYM { get; set; }
        public string EndYM { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string FullNameInChinese { get; set; }
        public string DepartmentName { get; set; }
        public int Flag { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
    }
}
