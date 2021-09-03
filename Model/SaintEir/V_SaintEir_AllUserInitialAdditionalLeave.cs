using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_AllUserInitialAdditionalLeave
    {
        public string UserId { get; set; }
        public string FullNameInChinese { get; set; }
        public int? IsAlive { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? p_AdditionalLeaveType { get; set; }
        public decimal? Hours { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
