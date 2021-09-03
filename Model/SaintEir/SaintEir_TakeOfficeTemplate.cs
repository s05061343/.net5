using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TakeOfficeTemplate
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
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
    }
}
