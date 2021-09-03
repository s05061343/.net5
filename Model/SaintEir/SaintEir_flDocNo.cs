using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flDocNo
    {
        public int Id { get; set; }
        public int DocTypeId { get; set; }
        public string IssueDate { get; set; }
        public int Seq { get; set; }

        public virtual SaintEir_flDocType DocType { get; set; }
    }
}
