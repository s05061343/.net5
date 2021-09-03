using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PRO2E_AUTH_ROLE_FUNC
    {
        public int RoleId { get; set; }
        public int MenuFuncId { get; set; }
        public int ID { get; set; }
        public int ReadAllBranch { get; set; }
        public int ReadAllUser { get; set; }
        public int ReadAllContent { get; set; }

        public virtual PRO2E_AUTH_MENU_FUNC MenuFunc { get; set; }
        public virtual PRO2E_AUTH_LOGIN_ROLE Role { get; set; }
    }
}
