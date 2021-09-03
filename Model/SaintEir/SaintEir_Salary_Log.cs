using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Salary_Log
    {
        public int Id { get; set; }
        public string YM { get; set; }
        public string UserId { get; set; }
        public string ProcessId { get; set; }
        public string Type { get; set; }
        public string JobTitle { get; set; }
        public string Name { get; set; }
        public DateTime ACStartDate { get; set; }
        public DateTime ACEndDate { get; set; }
        public int ScheduledDays { get; set; }
        public int ActualDays { get; set; }
        public int BasicSalary { get; set; }
        public int? AttendanceBonus { get; set; }
        public int? AddOnRegular { get; set; }
        public string AddOnRegularMomo { get; set; }
        public int? AddOnSpecial { get; set; }
        public string AddOnSpecialMemo { get; set; }
        public decimal? WorkingHourPerDay { get; set; }
        public int OvertimePay { get; set; }
        public string OvertimeMemo { get; set; }
        public int? AbsentDeduction { get; set; }
        public string AbsentMemo { get; set; }
        public int? LaborInsuranceDeduction { get; set; }
        public int? DependentsCount { get; set; }
        public int? HealthyInsuranceDeduction { get; set; }
        public int? AdjAmount { get; set; }
        public string AdjMemo { get; set; }
        public int? RetireInsuranceAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Error { get; set; }
        public int p_HourPayBase { get; set; }
        public int InsuranceAmount { get; set; }
        public int WithholdAmount { get; set; }
        public string WithholdMemo { get; set; }
        public int Flag { get; set; }
        public int TransferAmount { get; set; }
        public string OtherMemo { get; set; }
        public int? LaborInsuranceDays { get; set; }
        public int? LaborInsuranceAmount { get; set; }
        public int? LaborInsuranceBase { get; set; }
        public int? HealthInsuranceBase { get; set; }
        public int? RetireInsuranceBase { get; set; }
        public int? LaborInsuranceDeductionFinal { get; set; }
        public int? HealthyInsuranceDeductionFinal { get; set; }
        public int? RetireInsuranceCompanyAmountFinal { get; set; }
    }
}
