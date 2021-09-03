using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AccountClassify
    {
        public int AccountClassifyNo { get; set; }
        public string AccountClassifyName { get; set; }
        public int? ParentId { get; set; }
        public int? Flag { get; set; }
    }
}
