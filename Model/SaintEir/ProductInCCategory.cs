using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class ProductInCCategory
    {
        public int Id { get; set; }
        public int? BelongToProduct { get; set; }
        public int? BelongToCCategory { get; set; }
    }
}
