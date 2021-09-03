using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PRO2E_AUTH_FUNCTION_PATH
    {
        public int Id { get; set; }
        public int? MenuFuncId { get; set; }
        public string Path { get; set; }

        public virtual PRO2E_AUTH_MENU_FUNC MenuFunc { get; set; }
    }
}
