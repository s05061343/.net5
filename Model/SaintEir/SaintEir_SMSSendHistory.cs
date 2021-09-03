using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_SMSSendHistory
    {
        public int SMSSendHistoryNo { get; set; }
        public string BelongToCustomer { get; set; }
        public string BelongToType { get; set; }
        public string CustomerPhone { get; set; }
        public string SMSContent { get; set; }
        public string Subject { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? Flag { get; set; }
        public string BelongToBranch { get; set; }
        public int? IsSented { get; set; }
        public int? IsFinished { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? PostTime { get; set; }
        public string Status_Every8D { get; set; }
        public string Status_SMS { get; set; }
        public string BatchID { get; set; }
        public decimal? Cost { get; set; }
        public string Note { get; set; }
        public int AdvisoryEventNo { get; set; }
    }
}
