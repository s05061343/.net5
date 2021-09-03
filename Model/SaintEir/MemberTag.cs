using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MemberTag
    {
        public int MemberTagNo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
