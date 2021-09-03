using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flDocument_CurrentSubNode
    {
        public int Id { get; set; }
        public int flDocumentId { get; set; }
        public int NodeId { get; set; }
        public string Name { get; set; }
        public string UserList { get; set; }
        public string GroupList { get; set; }
        public int? Is_DirectSupervisor { get; set; }
        public string Is_Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedUserId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SupervisorLevel { get; set; }
    }
}
