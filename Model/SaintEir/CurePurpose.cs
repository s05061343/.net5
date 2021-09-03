using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class CurePurpose
    {
        public int CurePurposeNo { get; set; }
        public int? BelongToClassify { get; set; }
        public string Purpose { get; set; }
        public int? OrderBy { get; set; }
    }
}
