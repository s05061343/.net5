using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_JobAdjustment
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string DocNo { get; set; }
        public string UserId { get; set; }
        public string OldAssignBranchNo { get; set; }
        public string AssignBranchNo { get; set; }
        public int? Oldp_SalarySubject { get; set; }
        public int? p_SalarySubject { get; set; }
        public int? OldDepartmentId { get; set; }
        public int? DepartmentId { get; set; }
        public int? OldSalaryDepartmentId { get; set; }
        public int? SalaryDepartmentId { get; set; }
        public int? OldJobTitleId { get; set; }
        public int? JobTitleId { get; set; }
        public int? OldJobLevelId { get; set; }
        public int? JobLevelId { get; set; }
        public string OldJobTitle { get; set; }
        public string JobTitle { get; set; }
        public string OldEnglishJobTitle { get; set; }
        public string EnglishJobTitle { get; set; }
        public int? OldEmployeeTypeId { get; set; }
        public int? EmployeeTypeId { get; set; }
        public int? p_JobAdujstmentReasonId { get; set; }
        public int? Oldp_SalaryPayMethod { get; set; }
        public int? p_SalaryPayMethod { get; set; }
        public int? Oldp_SalaryCaculateMethod { get; set; }
        public int? p_SalaryCaculateMethod { get; set; }
        public int? Oldp_SalaryCaculateMethodIfAdjInMiddle { get; set; }
        public int? p_SalaryCaculateMethodIfAdjInMiddle { get; set; }
        public int? OldBasicSalary { get; set; }
        public int? BasicSalary { get; set; }
        public int? Oldp_TaxType { get; set; }
        public int? p_TaxType { get; set; }
        public decimal? OldTaxRate { get; set; }
        public decimal? TaxRate { get; set; }
        public int? OldIs_PaySalary { get; set; }
        public int? Is_PaySalary { get; set; }
        public int? OldIs_AttendanceBonus { get; set; }
        public int? Is_AttendanceBonus { get; set; }
        public int? OldAttendanceBonus { get; set; }
        public int? AttendanceBonus { get; set; }
        public int? OldIs_MealAllowance { get; set; }
        public int? Is_MealAllowance { get; set; }
        public int? OldMealAllowance { get; set; }
        public int? MealAllowance { get; set; }
        public int? OldIs_OverTimePay { get; set; }
        public int? Is_OverTimePay { get; set; }
        public int? OldOverTimePayId { get; set; }
        public int? OverTimePayId { get; set; }
        public int? OldIs_Welfare { get; set; }
        public int? Is_Welfare { get; set; }
        public decimal? OldWelfareRate { get; set; }
        public decimal? WelfareRate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? LeaveWithoutPayDays { get; set; }
        public DateTime? OriginalLeaveWithoutPayDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? Flag { get; set; }
        public int? Oldp_HourPayBase { get; set; }
        public int? p_HourPayBase { get; set; }
        public DateTime? OutStart { get; set; }
        public DateTime? OutEnd { get; set; }
        public DateTime? SystemProcessDate { get; set; }
    }
}
