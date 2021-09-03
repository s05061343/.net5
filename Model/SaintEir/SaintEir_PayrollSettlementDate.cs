using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PayrollSettlementDate
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string ModifyId { get; set; }
        public DateTime ModifyDay { get; set; }
    }
}
