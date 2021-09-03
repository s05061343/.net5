using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_LoginUserInBranch
    {
        public string UserId { get; set; }
        public string BranchNo { get; set; }

        public virtual SaintEir_Branch BranchNoNavigation { get; set; }
        public virtual PRO2E_AUTH_LOGIN_USER User { get; set; }
    }
}
