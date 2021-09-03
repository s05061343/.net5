using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_ShiftApplicationDetail
    {
        public int Id { get; set; }
        public string NewWorkingDayTypeName { get; set; }
        public string NewWorkingDayTypeCode { get; set; }
        public int NewWorkingDayTypeId { get; set; }
        public string OldWorkingDayTypeName { get; set; }
        public string OldWorkingDayTypeCode { get; set; }
        public int OldWorkingDayTypeId { get; set; }
        public DateTime YMD { get; set; }
        public int ShiftId { get; set; }
        public string UserId { get; set; }
        public int? DocumentStatus { get; set; }
        public int Flag { get; set; }
        public string DocNo { get; set; }
    }
}
