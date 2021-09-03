using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Resource
    {
        public SaintEir_Resource()
        {
            SaintEir_OperationItems = new HashSet<SaintEir_OperationItem>();
        }

        public int ResourceNo { get; set; }
        public string NameInChinese { get; set; }
        public string NameInEnglish { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? OrderBy { get; set; }
        public string BelongToBranch { get; set; }
        public string UserId { get; set; }
        public int? Flag { get; set; }

        public virtual ICollection<SaintEir_OperationItem> SaintEir_OperationItems { get; set; }
    }
}
