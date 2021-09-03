using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DrOrderQuickWord
    {
        public int QuickWordNo { get; set; }
        public string KeyWord { get; set; }
        public string Description { get; set; }
        public string OrderType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
