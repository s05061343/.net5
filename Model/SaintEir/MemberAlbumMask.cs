using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MemberAlbumMask
    {
        public int MaskNo { get; set; }
        public int? BelongToPostion { get; set; }
        public int? BelongToOption { get; set; }
        public int? BelongToGroup { get; set; }
        public int? Parent { get; set; }
        public int? OrderBy { get; set; }
        public string FilePath { get; set; }
        public string FileVersion { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public string PhotoName { get; set; }
        public string Description { get; set; }
    }
}
