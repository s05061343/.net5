using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ActivityList
    {
        public int ActivityNo { get; set; }
        public string ActivityName { get; set; }
        public string HostBranch { get; set; }
        public DateTime? ExecutionST { get; set; }
        public DateTime? ExecutionEN { get; set; }
        public int? Display { get; set; }
        public DateTime? DisplayDate_ST { get; set; }
        public DateTime? DisplayDate_EN { get; set; }
        public string UpdateURL { get; set; }
        public string BelongCategory { get; set; }
        public int? MemberNumberCount { get; set; }
        public int? Flag { get; set; }
    }
}
