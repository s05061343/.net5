using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_TakeOfficeApplication
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string DocNo { get; set; }
        public string UserId { get; set; }
        public int? p_ArriveType { get; set; }
        public int p_SalarySubject { get; set; }
        public string BranchNo { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoleId { get; set; }
        public int? JobTitleId { get; set; }
        public int? JobLevelId { get; set; }
        public int? SalaryDepartmentId { get; set; }
        public int? EmployeeTypeId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string EnglishJobTitle { get; set; }
        public int? p_SalaryPayMethod { get; set; }
        public int? p_SalaryCaculateMethod { get; set; }
        public int? BasicSalary { get; set; }
        public int? p_TaxType { get; set; }
        public decimal? TaxRate { get; set; }
        public int? LastEmployerContribution { get; set; }
        public int? LastWorkerContribution { get; set; }
        public int? Is_PaySalary { get; set; }
        public int? Is_AttendanceBonus { get; set; }
        public int? AttendanceBonus { get; set; }
        public int? Is_MealAllowance { get; set; }
        public int? MealAllowance { get; set; }
        public int? Is_OverTimePay { get; set; }
        public int? OverTimePayId { get; set; }
        public int? Is_Welfare { get; set; }
        public decimal? WelfareRate { get; set; }
        public string Memo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string EmployeeName { get; set; }
        public string CurrentVerifierId { get; set; }
        public string FlowNodeName { get; set; }
        public string CurrentVerifierName { get; set; }
        public int? DocumentStatus { get; set; }
        public string JobTitle { get; set; }
        public string DepartmentName { get; set; }
        public string RoleName { get; set; }
        public string JobTitleName { get; set; }
        public string JobLevelName { get; set; }
        public string EmployeeTypeName { get; set; }
        public string SalaryDepartmentName { get; set; }
        public string CreatorName { get; set; }
        public string ApproverName { get; set; }
        public int? DocumentId { get; set; }
        public string BranchName { get; set; }
        public int? p_HourPayBase { get; set; }
        public int Flag { get; set; }
        public string SalaryBranchNo { get; set; }
    }
}
