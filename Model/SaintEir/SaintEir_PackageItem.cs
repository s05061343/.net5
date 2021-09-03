using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PackageItem
    {
        public int PackageItemNo { get; set; }
        public int? ProductNo { get; set; }
        public int? Quantity { get; set; }
        public int? BelongToPackage { get; set; }
        public int? ItemValue { get; set; }
        public int? BelongToCategory { get; set; }
    }
}
