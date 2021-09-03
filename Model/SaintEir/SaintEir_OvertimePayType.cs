using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_OvertimePayType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? MaleTaxFreeHours { get; set; }
        public int? FemaleTaxFreeHours { get; set; }
        public int? NormalDayWarming { get; set; }
        public int? NormalDayLimit { get; set; }
        public int? En_OverNormalDayLimitAction { get; set; }
        public int? HolidayLimit { get; set; }
        public int? En_OverHolidayDayLimitAction { get; set; }
        public int? En_OvertimeDefaultAction { get; set; }
        public int? NDFoodAllowanceStartHour { get; set; }
        public int? NDFoodAllowanceIntervalHour { get; set; }
        public int? NDFoodAllowanceStart { get; set; }
        public int? NDFoodAllowancePerInterval { get; set; }
        public int? En_NDOvertimePayType { get; set; }
        public decimal? NDOvertimePayA { get; set; }
        public decimal? NDOvertimePayB { get; set; }
        public decimal? NDOvertimePayC { get; set; }
        public decimal? NDOvertimePayD { get; set; }
        public int? HDFoodAllowanceInterval { get; set; }
        public int? HDFoodAllowance { get; set; }
        public int? En_HDOvertimePayType { get; set; }
        public decimal? HDOvertimePayA { get; set; }
        public decimal? HDOvertimePayB { get; set; }
        public decimal? HDOvertimePayC { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
        public string Memo { get; set; }
    }
}
