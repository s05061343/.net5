using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_EMailLog_Attachment
    {
        public long ID { get; set; }
        public string Filename { get; set; }
        public string ContentType { get; set; }
        public long EMailLogID { get; set; }

        public virtual SaintEir_EMailLog EMailLog { get; set; }
    }
}
