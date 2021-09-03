using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PRO2E_AUTH_MENU_FUNC
    {
        public PRO2E_AUTH_MENU_FUNC()
        {
            InverseParent = new HashSet<PRO2E_AUTH_MENU_FUNC>();
            PRO2E_AUTH_FUNCTION_PATHs = new HashSet<PRO2E_AUTH_FUNCTION_PATH>();
            PRO2E_AUTH_ROLE_FUNCs = new HashSet<PRO2E_AUTH_ROLE_FUNC>();
        }

        public int Id { get; set; }
        public string MenuFuncName { get; set; }
        public int? ParentId { get; set; }
        public int? ListOrder { get; set; }
        public string MainPath { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int? Flag { get; set; }
        public string DomainName { get; set; }

        public virtual PRO2E_AUTH_MENU_FUNC Parent { get; set; }
        public virtual PRO2E_AUTH_FUNC_OPT PRO2E_AUTH_FUNC_OPT { get; set; }
        public virtual ICollection<PRO2E_AUTH_MENU_FUNC> InverseParent { get; set; }
        public virtual ICollection<PRO2E_AUTH_FUNCTION_PATH> PRO2E_AUTH_FUNCTION_PATHs { get; set; }
        public virtual ICollection<PRO2E_AUTH_ROLE_FUNC> PRO2E_AUTH_ROLE_FUNCs { get; set; }
    }
}
