using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class Consent
    {
        public int ConsentNo { get; set; }
        public int? BelongToCategory { get; set; }
        public string SerialNumber { get; set; }
        public string Version { get; set; }
        public string Title { get; set; }
        public string ConsentContent { get; set; }
        public string Category { get; set; }
        public int? Reference { get; set; }
        public int? OrderBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public int? Share { get; set; }
        public int RequireDr { get; set; }
        public int RequireFollower { get; set; }
        public int RequireNurse { get; set; }
    }
}
