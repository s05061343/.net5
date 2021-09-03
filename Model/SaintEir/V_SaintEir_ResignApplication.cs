using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_ResignApplication
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string DocNo { get; set; }
        public string UserId { get; set; }
        public int Is_NoHire { get; set; }
        public string AssignBranchNo { get; set; }
        public int? DepartmentId { get; set; }
        public int? SalaryDepartmentId { get; set; }
        public int? JobTitleId { get; set; }
        public int? JobLevelId { get; set; }
        public string JobTitle { get; set; }
        public string EnglishJobTitle { get; set; }
        public int? EmployeeTypeId { get; set; }
        public DateTime? TakeOfficeEffectiveDate { get; set; }
        public int? SeniorityInMonth { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public string ResignExplanation { get; set; }
        public string NoHireReason { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? CorrectionDate { get; set; }
        public string CorrecterId { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Memo { get; set; }
        public string EmployeeName { get; set; }
        public string CreatorName { get; set; }
        public int? DocumentStatus { get; set; }
        public string CurrentVerifierId { get; set; }
        public string FlowNodeName { get; set; }
        public DateTime? FinalUIDate { get; set; }
        public int? DocumentId { get; set; }
        public string BranchName { get; set; }
        public int p_ResignType { get; set; }
        public int? p_SalarySubject { get; set; }
        public int? p_ResignReason { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public string DepartmentName { get; set; }
        public string SalaryDepartmentName { get; set; }
        public string JobTitleName { get; set; }
        public string JobLevelName { get; set; }
        public string EmployeeTypeName { get; set; }
        public int Flag { get; set; }
        public DateTime? SystemProcessDate { get; set; }
        public int? p_EmployeeStatus { get; set; }
        public string EmployeeStatusName { get; set; }
        public string CurrentVerifierName { get; set; }
    }
}
