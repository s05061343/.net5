using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_CashFlowForecast
    {
        public int CashFlowForecastNo { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? BelongToClassify { get; set; }
        public int? ForecastAmount { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Flag { get; set; }
    }
}
