using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PRO2E_AUTH_LOGIN_ROLE
    {
        public PRO2E_AUTH_LOGIN_ROLE()
        {
            PRO2E_AUTH_ROLE_FUNCs = new HashSet<PRO2E_AUTH_ROLE_FUNC>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string LoweredRoleName { get; set; }
        public string Description { get; set; }
        public string BackgroundColor { get; set; }

        public virtual ICollection<PRO2E_AUTH_ROLE_FUNC> PRO2E_AUTH_ROLE_FUNCs { get; set; }
    }
}
