using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_ConsumptionConfirm
    {
        public int InProcessServiceNo { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string FullNameInChinese { get; set; }
        public string CreatedUser { get; set; }
        public int ConsumptionHistoryNo { get; set; }
        public DateTime? ConsumptionDate { get; set; }
        public int MemberNo { get; set; }
        public string AnamnesisNo { get; set; }
        public string FullName { get; set; }
        public int ProductKeyNo { get; set; }
        public string ProductNo { get; set; }
        public string NameInChinese { get; set; }
        public int? Quantity { get; set; }
        public int? AuthStatus { get; set; }
        public string ByDr { get; set; }
        public string ByDrName { get; set; }
        public int? TodayDutyDr { get; set; }
        public string ByFollowerA { get; set; }
        public string ByFollowerAName { get; set; }
        public string ByFollowerB { get; set; }
        public string ByFollowerBName { get; set; }
        public string ByChecker { get; set; }
        public string ByCheckerName { get; set; }
        public int? ConsentRequireCount { get; set; }
        public int? SignDocRequireCount { get; set; }
        public int? SignDocCount { get; set; }
        public int? MedicalRecordFormRequireCount { get; set; }
        public int? MedicalRecordRequireCount { get; set; }
        public int? MedicalRecordCount { get; set; }
        public int? ConsumptionConfirmItemCount { get; set; }
        public int? TotalPhoto { get; set; }
        public int? ConsumableCount { get; set; }
        public int? MaterialConsumtpionCount { get; set; }
        public string Signature { get; set; }
    }
}
