using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PendingDocument
    {
        public int PendingNo { get; set; }
        public string PendingType { get; set; }
        public int? BelongToDocumentId { get; set; }
        public string BelongToDocumentName { get; set; }
        public string ProductName { get; set; }
        public int? BelonToMemberNo { get; set; }
        public string Doctor { get; set; }
        public string Attendant { get; set; }
        public string Nurse { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
