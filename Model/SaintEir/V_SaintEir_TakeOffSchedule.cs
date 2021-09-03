using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_TakeOffSchedule
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string YM { get; set; }
        public DateTime OffDay { get; set; }
        public int? WorkingDayTypeId { get; set; }
        public string TakeOffTypeName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string WorkingDayTypeCode { get; set; }
    }
}
