using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class PRO2E_AUTH_OPRT_ACTION
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual PRO2E_AUTH_FUNC_OPT PRO2E_AUTH_FUNC_OPT { get; set; }
    }
}
