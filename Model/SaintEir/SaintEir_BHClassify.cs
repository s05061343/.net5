using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BHClassify
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
    }
}
