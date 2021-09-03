using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CustomCategory
    {
        public int CategoryNo { get; set; }
        public string CategoryType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProductClassify { get; set; }
        public int? AccountingNo { get; set; }
        public int? OrderBy { get; set; }
        public string Color { get; set; }
        public int? ParentId { get; set; }
        public int? Flag { get; set; }
    }
}
