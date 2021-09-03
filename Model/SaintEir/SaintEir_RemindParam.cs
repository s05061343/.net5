using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_RemindParam
    {
        public int RemindParamNo { get; set; }
        public string Param { get; set; }
        public int? BelongToProductNo { get; set; }
        public string TreatmentType { get; set; }
        public int? Flag { get; set; }
    }
}
