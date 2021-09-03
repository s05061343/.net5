using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TransferMemberHistory
    {
        public int TransferMemberHistoryNo { get; set; }
        public int? BelongToServiceControl { get; set; }
        public string TransferFrom { get; set; }
        public string TransferTo { get; set; }
        public DateTime? TransferTime { get; set; }
    }
}
