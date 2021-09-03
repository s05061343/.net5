using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SignDocItem
    {
        public int SignDocItemNo { get; set; }
        public int? BelongToSignDoc { get; set; }
        public string ItemId { get; set; }
        public int? BelongToSignature { get; set; }
    }
}
