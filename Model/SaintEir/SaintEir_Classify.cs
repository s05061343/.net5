using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Classify
    {
        public int ClassNo { get; set; }
        public string ClassCode { get; set; }
        public string ClassChtTitle { get; set; }
        public string ClassEngTitle { get; set; }
        public int? ClassSort { get; set; }
        public int? Flag { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ParentClass { get; set; }
        public int? Type { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
