using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AppRule
    {
        public string RuleId { get; set; }
        public int? RuleRange { get; set; }
        public int? MaxCount { get; set; }
        public int? PunishValue { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
