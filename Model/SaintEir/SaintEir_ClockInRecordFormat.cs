using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ClockInRecordFormat
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Length { get; set; }
        public int? StartLine { get; set; }
        public int Is_InOutString { get; set; }
        public string InString { get; set; }
        public string OutString { get; set; }
        public string OrverTimeInString { get; set; }
        public string OvertimeOutString { get; set; }
        public int? RepeatInterval { get; set; }
        public int En_YearFormat { get; set; }
        public int CardNoStart { get; set; }
        public int CardNoEnd { get; set; }
        public int InOutStringStart { get; set; }
        public int InOutStringEnd { get; set; }
        public int? BeforeMinutes { get; set; }
        public int? AfterMinutes { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public int MonthStart { get; set; }
        public int MonthEnd { get; set; }
        public int DayStart { get; set; }
        public int DayEnd { get; set; }
        public int HourStart { get; set; }
        public int HourEnd { get; set; }
        public int MinuteStart { get; set; }
        public int MinuteEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Flag { get; set; }
    }
}
