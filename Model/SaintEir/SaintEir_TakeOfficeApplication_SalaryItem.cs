using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TakeOfficeApplication_SalaryItem
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int ItemId { get; set; }
        public int Value { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Memo { get; set; }
    }
}
