using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_RegularListItem
    {
        public int RegularListItemNo { get; set; }
        public string BelongToRegularList { get; set; }
        public int? ItemNo { get; set; }
        public string Type { get; set; }
        public int? OrderBy { get; set; }
    }
}
