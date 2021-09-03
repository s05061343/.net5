using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SMSWording
    {
        public int SMSWordingNo { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? Flag { get; set; }
        public string Type { get; set; }
        public int? AmountStart { get; set; }
        public int? AmountEnd { get; set; }
        public int? SetDay { get; set; }
        public string LanguageCode { get; set; }
    }
}
