using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_OperationItem
    {
        public int OperationItemNo { get; set; }
        public string NameInChinese { get; set; }
        public string NameInEnglish { get; set; }
        public int? BelongToResource { get; set; }

        public virtual SaintEir_Resource BelongToResourceNavigation { get; set; }
    }
}
