using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_EMailLog
    {
        public SaintEir_EMailLog()
        {
            SaintEir_EMailLog_Addresses = new HashSet<SaintEir_EMailLog_Address>();
            SaintEir_EMailLog_Attachments = new HashSet<SaintEir_EMailLog_Attachment>();
        }

        public long ID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<SaintEir_EMailLog_Address> SaintEir_EMailLog_Addresses { get; set; }
        public virtual ICollection<SaintEir_EMailLog_Attachment> SaintEir_EMailLog_Attachments { get; set; }
    }
}
