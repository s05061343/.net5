using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class CourseMaterial
    {
        public int CourseMaterialNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Type { get; set; }
        public int? Length { get; set; }
        public string Path { get; set; }
        public int? BelongToCourse { get; set; }
        public int? OrderBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
