using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_EMailWording
    {
        public int EMailWordingNo { get; set; }
        public string Type { get; set; }
        public string Subject { get; set; }
        public string ContentPath { get; set; }
        public string RelpyUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string LanguageCode { get; set; }
        public int Flag { get; set; }
    }
}
