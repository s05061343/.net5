using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PRO2E_AUTH_FUNC_OPT
    {
        public int Id { get; set; }
        public int? FuncOprtId { get; set; }

        public virtual PRO2E_AUTH_OPRT_ACTION FuncOprt { get; set; }
        public virtual PRO2E_AUTH_MENU_FUNC IdNavigation { get; set; }
    }
}
