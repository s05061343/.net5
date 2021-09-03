using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_flLog
    {
        public int DocumentId { get; set; }
        public int Id { get; set; }
        public int EN_Type { get; set; }
        public int NodeId { get; set; }
        public int FlowId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int? Is_OK { get; set; }
        public DateTime HappenDate { get; set; }
        public string Memo { get; set; }
        public string SystemMemo { get; set; }
        public string VerifierName { get; set; }
        public string DocContent { get; set; }
        public string Action { get; set; }
        public string Email { get; set; }
    }
}
