using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ClockInRecord
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string CardNo { get; set; }
        public DateTime YMD { get; set; }
        public DateTime Time { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
