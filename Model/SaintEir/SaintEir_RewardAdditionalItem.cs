using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_RewardAdditionalItem
    {
        public long RewardAdditionalItemNO { get; set; }
        public string BelongToUser { get; set; }
        public string BelongToBranch { get; set; }
        public string Reason { get; set; }
        public long? ProductKeyNo { get; set; }
        public string CustomerName { get; set; }
        public string TableName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Amount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Flag { get; set; }
        public Guid? GroupID { get; set; }
        public int Lock { get; set; }
        public long ByHistory { get; set; }
        public int ItemType { get; set; }
        public DateTime? RationDate { get; set; }
    }
}
