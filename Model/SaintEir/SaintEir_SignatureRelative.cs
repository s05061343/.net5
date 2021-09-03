using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SignatureRelative
    {
        public int SignatureRelativeNo { get; set; }
        public int? Signature { get; set; }
        public string ValueType { get; set; }
        public int? ValueNo { get; set; }
        public DateTime? SignedDate { get; set; }
        public string SignedBy { get; set; }
    }
}
