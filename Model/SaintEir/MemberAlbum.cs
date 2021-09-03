using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MemberAlbum
    {
        public int MemberAlbumNo { get; set; }
        public int? BelongToConsumption { get; set; }
        public int? BelongToMember { get; set; }
        public DateTime? PhotoDate { get; set; }
        public int? Class { get; set; }
        public int? Position { get; set; }
        public int? Operation { get; set; }
        public int? Status { get; set; }
        public int? StatusCount { get; set; }
        public int? TotalPhoto { get; set; }
        public string Description { get; set; }
        public int? Flag { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PhotoBy { get; set; }
    }
}
