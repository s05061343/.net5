using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Signature
    {
        public SaintEir_Signature()
        {
            SaintEir_InProcessServices = new HashSet<SaintEir_InProcessService>();
        }

        public int SignatureNo { get; set; }
        public string SignaturePath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }

        public virtual ICollection<SaintEir_InProcessService> SaintEir_InProcessServices { get; set; }
    }
}
