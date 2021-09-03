using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MemberAlbumAttribute
    {
        public int AttributeNo { get; set; }
        public int? BelongToAlbum { get; set; }
        public int? Class { get; set; }
        public int? Position { get; set; }
        public int? Operation { get; set; }
        public int? Status { get; set; }
        public int? Flag { get; set; }
    }
}
