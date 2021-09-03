using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_flNode_User
    {
        public int Id { get; set; }
        public int NodeId { get; set; }
        public string UserId { get; set; }
        public int DocTypeId { get; set; }
        public int FlowId { get; set; }
        public int Flag { get; set; }
        public string FullNameInChinese { get; set; }
    }
}
