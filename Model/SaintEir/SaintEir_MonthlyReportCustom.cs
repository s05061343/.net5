using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MonthlyReportCustom
    {
        public int ReportNo { get; set; }
        public DateTime? Date { get; set; }
        public string Category { get; set; }
        public decimal? Income { get; set; }
        public string BranchNo { get; set; }
    }
}
