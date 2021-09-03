using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_WorkSheet
    {
        public int WorkSheetNo { get; set; }
        public string UserId { get; set; }
        public DateTime? EventStart { get; set; }
        public DateTime? EventEnd { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Agent { get; set; }
        public string EventStartTime { get; set; }
        public string EventEndTime { get; set; }
    }
}
