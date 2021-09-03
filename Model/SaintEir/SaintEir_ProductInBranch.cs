using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ProductInBranch
    {
        public int ProductInBranchNo { get; set; }
        public int? BelongToProduct { get; set; }
        public string InBranch { get; set; }
        public string ProductInBranchType { get; set; }
    }
}
