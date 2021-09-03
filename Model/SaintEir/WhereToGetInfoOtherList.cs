using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class WhereToGetInfoOtherList
    {
        public int id { get; set; }
        public int BelongToMember { get; set; }
        public int? BelongtoCustomCategory { get; set; }
        public string Note { get; set; }

        public virtual SaintEir_Member BelongToMemberNavigation { get; set; }
    }
}
