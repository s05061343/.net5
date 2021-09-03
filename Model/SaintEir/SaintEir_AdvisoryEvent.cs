using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AdvisoryEvent
    {
        public int AdvisoryEventNo { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CallTimeSlot { get; set; }
        public DateTime? AdvisoryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string BelongToBranch { get; set; }
        public int? IsFinished { get; set; }
        public string CommunicateKey { get; set; }
        public string NewestHistoryNo { get; set; }
        public int Type { get; set; }
        public int MemberNo { get; set; }
        public string LanguageCode { get; set; }
    }
}
