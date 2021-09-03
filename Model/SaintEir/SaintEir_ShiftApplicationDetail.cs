using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ShiftApplicationDetail
    {
        public int Id { get; set; }
        public int ShiftId { get; set; }
        public DateTime YMD { get; set; }
        public int OldWorkingDayTypeId { get; set; }
        public string OldWorkingDayTypeCode { get; set; }
        public string OldWorkingDayTypeName { get; set; }
        public int NewWorkingDayTypeId { get; set; }
        public string NewWorkingDayTypeCode { get; set; }
        public string NewWorkingDayTypeName { get; set; }
    }
}
