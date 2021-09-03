using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_RegularList
    {
        public int RegularListNo { get; set; }
        public string BelongToUser { get; set; }
        public string GvName { get; set; }
        public int? MenuFuncId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? OrderBy { get; set; }
    }
}
