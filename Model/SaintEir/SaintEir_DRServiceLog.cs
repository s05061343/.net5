using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DRServiceLog
    {
        public int Id { get; set; }
        public int DRServiceNo { get; set; }
        public int ColumnType { get; set; }
        public DateTime CheckInTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
