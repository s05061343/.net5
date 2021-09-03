using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class ProductInSm
    {
        public int ProductInSmsNo { get; set; }
        public int? BelongToSms { get; set; }
        public int? BelongToProduct { get; set; }
        public int? Quantity { get; set; }
    }
}
