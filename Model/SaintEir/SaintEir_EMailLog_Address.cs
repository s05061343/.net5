using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_EMailLog_Address
    {
        public long ID { get; set; }
        public string Address { get; set; }
        public int Type { get; set; }
        public long EMailLogID { get; set; }
        public long MemberNo { get; set; }

        public virtual SaintEir_EMailLog EMailLog { get; set; }
    }
}
