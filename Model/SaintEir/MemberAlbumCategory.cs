using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MemberAlbumCategory
    {
        public int CategoryNo { get; set; }
        public string Title { get; set; }
        public int? Type { get; set; }
        public int? BelongToClass { get; set; }
        public int? OrderBy { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string BelongToPosition { get; set; }
    }
}
