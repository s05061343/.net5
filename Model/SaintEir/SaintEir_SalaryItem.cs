using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SalaryItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int En_Type { get; set; }
        public string Memo { get; set; }
        public int Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Is_Regular { get; set; }
        public int Is_Gift { get; set; }
        public int Is_Withhold { get; set; }
        public int Is_Ratio { get; set; }
    }
}
