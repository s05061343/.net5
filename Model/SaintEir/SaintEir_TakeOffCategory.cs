using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TakeOffCategory
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public int Is_ThreeDayOnly { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
