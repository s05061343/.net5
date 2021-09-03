using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ActivityMember
    {
        public int ActivityMemberNO { get; set; }
        public int? MemberNo { get; set; }
        public string SessionId { get; set; }
        public string AnamnesisNo { get; set; }
        public string BelongToBranch { get; set; }
        public string FullName { get; set; }
        public int? CurrentAge { get; set; }
        public string FullNameInChinese { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string WhereToGetInfo { get; set; }
        public string Mobile_1 { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string VIPTag { get; set; }
        public string BranchName { get; set; }
        public int? LastConsumption { get; set; }
        public int? PurchaseCount { get; set; }
        public int? AVGTotal { get; set; }
        public string RFMTag { get; set; }
        public string RFMStyleCode { get; set; }
        public int? Total { get; set; }
        public string sex { get; set; }
        public int? NotPayYet { get; set; }
        public int? BelongToActivity { get; set; }
        public string ActivityGiftRequest { get; set; }
        public string ActivityCheckGiftNote { get; set; }
        public string ActivityGiftItem { get; set; }
        public int? Flag { get; set; }
        public DateTime? ActivityGiftRequestDate { get; set; }
        public string ActivityGiftName { get; set; }
        public string ActivityMemberID { get; set; }
    }
}
