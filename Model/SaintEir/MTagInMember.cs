using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MTagInMember
    {
        public int MTagInMemberNo { get; set; }
        public int? BelongToMTag { get; set; }
        public int? BelongToMember { get; set; }
    }
}
