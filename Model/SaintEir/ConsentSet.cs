using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class ConsentSet
    {
        public int ConsentSetNo { get; set; }
        public int? BelongToConsent { get; set; }
        public int? BelongToProduct { get; set; }
        public int? Flag { get; set; }
        public int? Require { get; set; }
    }
}
