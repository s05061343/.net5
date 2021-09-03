using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AttendantFaultRecordAttachment
    {
        public long ID { get; set; }
        public Guid? FileNode_id { get; set; }
        public long? AttendantFaultRecordVO_id { get; set; }

        public virtual SaintEir_AttendantFaultRecord AttendantFaultRecordVO { get; set; }
        public virtual SaintEir_FSFileVirtualNode FileNode { get; set; }
    }
}
