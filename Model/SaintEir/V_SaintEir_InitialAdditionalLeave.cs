using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_InitialAdditionalLeave
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int p_AdditionalLeaveType { get; set; }
        public decimal Hours { get; set; }
        public DateTime ExpireDate { get; set; }
        public int SourceId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
