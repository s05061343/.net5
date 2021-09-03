using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class UserStatusLog
    {
        public DateTime LogDate { get; set; }
        public string UserId { get; set; }
        public int? p_EmployeeStatus { get; set; }
    }
}
