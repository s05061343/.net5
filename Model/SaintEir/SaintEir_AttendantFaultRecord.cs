using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AttendantFaultRecord
    {
        public SaintEir_AttendantFaultRecord()
        {
            SaintEir_AttendantFaultRecordAttachments = new HashSet<SaintEir_AttendantFaultRecordAttachment>();
        }

        public long AttendantFaultRecordNo { get; set; }
        public long BelongToRule { get; set; }
        public int Points { get; set; }
        public string BelongToUser { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Comment { get; set; }
        public string AppealReason { get; set; }
        public int FlowOfReview { get; set; }
        public int Flag { get; set; }
        public int Lock { get; set; }
        public int CreatedByDepartment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<SaintEir_AttendantFaultRecordAttachment> SaintEir_AttendantFaultRecordAttachments { get; set; }
    }
}
