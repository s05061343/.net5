using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BranchInCCategory
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string BranchNo { get; set; }
        public int? CategoryNo { get; set; }
    }
}
