using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flNode
    {
        public int Id { get; set; }
        public int DocTypeId { get; set; }
        public int FlowId { get; set; }
        public string BatchKey { get; set; }
        public string Name { get; set; }
        public int En_Type { get; set; }
        public int? NextId { get; set; }
        public int? NextYId { get; set; }
        public int? NextNId { get; set; }
        public int Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string GroupList { get; set; }
        public string UserList { get; set; }
        public int? Is_SupervisorOnly { get; set; }
        public int? Is_DirectSupervisor { get; set; }
        public string Equation { get; set; }
        public string ValidatorJson { get; set; }
    }
}
