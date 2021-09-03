using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_FSFileVirtualNode
    {
        public SaintEir_FSFileVirtualNode()
        {
            SaintEir_AttendantFaultRecordAttachments = new HashSet<SaintEir_AttendantFaultRecordAttachment>();
        }

        public Guid ID { get; set; }
        public string Extension { get; set; }
        public string Name { get; set; }
        public string PhysicalPath { get; set; }
        public string RelativePath { get; set; }
        public int? NodeType { get; set; }
        public Guid? ParentID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Flag { get; set; }

        public virtual ICollection<SaintEir_AttendantFaultRecordAttachment> SaintEir_AttendantFaultRecordAttachments { get; set; }
    }
}
