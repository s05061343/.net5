using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AttendantFaultRule
    {
        public long ID { get; set; }
        public string FaultNo { get; set; }
        public string Category { get; set; }
        public int BelongToDepartment { get; set; }
        public bool JudgeRight { get; set; }
        public string Frequency { get; set; }
        public string FaultContent { get; set; }
        public int Point { get; set; }
        public int Roles { get; set; }
        public int Flag { get; set; }
        public int FlowOfReview { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? VersionId { get; set; }

        public virtual SaintEir_AttendantFaultVersion Version { get; set; }
    }
}
