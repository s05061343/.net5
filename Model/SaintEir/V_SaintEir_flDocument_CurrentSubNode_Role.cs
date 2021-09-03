using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_flDocument_CurrentSubNode_Role
    {
        public int Id { get; set; }
        public int SubNodeId { get; set; }
        public int RoleId { get; set; }
        public int flDocumentId { get; set; }
        public int NodeId { get; set; }
        public string NodeName { get; set; }
        public string UserList { get; set; }
        public string GroupList { get; set; }
        public int? Is_DirectSupervisor { get; set; }
        public string Is_Deleted { get; set; }
    }
}
