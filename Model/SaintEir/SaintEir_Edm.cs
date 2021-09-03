using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Edm
    {
        public int EdmNo { get; set; }
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
