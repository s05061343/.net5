using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AccountMonetary
    {
        public int MonetaryKeyNo { get; set; }
        public string MonetaryNo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Rate { get; set; }
        public int? IsDefault { get; set; }
        public int? Flag { get; set; }
    }
}
