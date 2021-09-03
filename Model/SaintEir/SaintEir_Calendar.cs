using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Calendar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Is_Holiday { get; set; }
        public int Is_Weekend { get; set; }
        public int Is_WorkingDay { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
