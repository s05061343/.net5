using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_User_SalaryItem
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ItemId { get; set; }
        public int Value { get; set; }
        public string Memo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int En_Type { get; set; }
    }
}
