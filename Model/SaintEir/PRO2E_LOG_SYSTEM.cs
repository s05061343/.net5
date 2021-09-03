using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PRO2E_LOG_SYSTEM
    {
        public int Id { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Fucntion { get; set; }
        public string SubFucntion { get; set; }
        public string Action { get; set; }
        public string UpdateId { get; set; }
        public string Note { get; set; }
        public string UpdateClassName { get; set; }
        public string IpAddress { get; set; }
    }
}
