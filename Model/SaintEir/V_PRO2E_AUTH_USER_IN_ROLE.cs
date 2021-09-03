using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_PRO2E_AUTH_USER_IN_ROLE
    {
        public int RoleId { get; set; }
        public string UserId { get; set; }
        public string FullNameInChinese { get; set; }
        public string RoleName { get; set; }
        public int? IsAlive { get; set; }
    }
}
