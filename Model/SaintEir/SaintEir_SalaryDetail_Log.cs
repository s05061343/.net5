using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SalaryDetail_Log
    {
        public int Id { get; set; }
        public string YM { get; set; }
        public string UserId { get; set; }
        public int? ItemId { get; set; }
        public string ProcessId { get; set; }
        public string Type { get; set; }
        public int En_Type { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public string Memo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Is_Ratio { get; set; }
        public int Is_Regular { get; set; }
        public int Is_Gift { get; set; }
        public int Is_Withhold { get; set; }
        public string ItemCode { get; set; }
        public int Flag { get; set; }
    }
}
