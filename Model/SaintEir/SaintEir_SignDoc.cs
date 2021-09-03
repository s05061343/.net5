using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SignDoc
    {
        public SaintEir_SignDoc()
        {
            SaintEir_DigitalFiles = new HashSet<SaintEir_DigitalFile>();
            SaintEir_DocRequireHistories = new HashSet<SaintEir_DocRequireHistory>();
            SaintEir_SignDocRelatives = new HashSet<SaintEir_SignDocRelative>();
        }

        public int SignDocNo { get; set; }
        public int? BelongToConsent { get; set; }
        public int? IsComplete { get; set; }
        public string DocTemp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? BelongToMember { get; set; }
        public int? Flag { get; set; }
        public int? Status { get; set; }
        public DateTime? SignedDate { get; set; }
        public string ByDr { get; set; }
        public string ByFollower { get; set; }
        public string ByNurse { get; set; }
        public string Application { get; set; }

        public virtual ICollection<SaintEir_DigitalFile> SaintEir_DigitalFiles { get; set; }
        public virtual ICollection<SaintEir_DocRequireHistory> SaintEir_DocRequireHistories { get; set; }
        public virtual ICollection<SaintEir_SignDocRelative> SaintEir_SignDocRelatives { get; set; }
    }
}
