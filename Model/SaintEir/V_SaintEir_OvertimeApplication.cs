using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_OvertimeApplication
    {
        public string EmployeeName { get; set; }
        public string CreatorName { get; set; }
        public string FlowNodeName { get; set; }
        public int Id { get; set; }
        public string DocNo { get; set; }
        public string UserId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Memo { get; set; }
        public int p_OvertimeCompensatoryId { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ExtendDate { get; set; }
        public DateTime HappenDate { get; set; }
        public int? WorkingDayTypeId { get; set; }
        public DateTime EstimateStartDate { get; set; }
        public decimal EstimateHours { get; set; }
        public decimal EstimateAHours { get; set; }
        public decimal EstimateBHours { get; set; }
        public decimal EstimateCHours { get; set; }
        public decimal EstimateHHours { get; set; }
        public DateTime? CorrectDate { get; set; }
        public string CorrectorId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Is_Holiday { get; set; }
        public int Is_WorkingTypeAllowance { get; set; }
        public DateTime EstimateEndDate { get; set; }
        public string OvertimeCompensatoryName { get; set; }
        public string WorkingDayTypeName { get; set; }
        public int? DocumentId { get; set; }
        public int? DocumentStatus { get; set; }
        public string CurrentVerifierId { get; set; }
        public DateTime EstimateSalaryDay { get; set; }
        public DateTime ActualStartDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public decimal ActualHours { get; set; }
        public decimal ActualAHours { get; set; }
        public decimal ActualBHours { get; set; }
        public decimal ActualCHours { get; set; }
        public decimal ActualHHours { get; set; }
        public DateTime ActualSalaryDay { get; set; }
        public int? VerificationId { get; set; }
        public int Flag { get; set; }
        public int? IsAlive { get; set; }
        public string CurrentVerifierName { get; set; }
    }
}
