using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_flNode_Role
    {
        public int Id { get; set; }
        public int NodeId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int Flag { get; set; }
        public int DocTypeId { get; set; }
        public int FlowId { get; set; }
    }
}
