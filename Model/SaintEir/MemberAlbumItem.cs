using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MemberAlbumItem
    {
        public int MemberAlbumItemNo { get; set; }
        public int? BelongToAlbum { get; set; }
        public string PhotoPath { get; set; }
        public string ThumbPath { get; set; }
        public DateTime? TakenDate { get; set; }
        public int Flag { get; set; }
    }
}
