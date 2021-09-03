using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flDocRow
    {
        public int Id { get; set; }
        public int DocTypeId { get; set; }
        public int En_RowType { get; set; }
        public string Is_Deleted { get; set; }
        public int? Seq { get; set; }
    }
}
