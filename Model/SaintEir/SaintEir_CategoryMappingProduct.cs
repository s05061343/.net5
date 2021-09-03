using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CategoryMappingProduct
    {
        public int Id { get; set; }
        public int? BelongToCategoryNo { get; set; }
        public string BelongToCategoryType { get; set; }
        public int ItemKey { get; set; }
        public string ItemType { get; set; }
        public string BelongToBranch { get; set; }
        public int? flag { get; set; }
    }
}
