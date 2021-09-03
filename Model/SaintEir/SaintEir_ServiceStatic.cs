using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ServiceStatic
    {
        public int ServiceStaticNo { get; set; }
        public DateTime? StaticDate { get; set; }
        public int? MemberCount { get; set; }
        public int? ServiceCount { get; set; }
        public int? ConsumptionCount { get; set; }
        public string MemberString { get; set; }
        public string ServiceString { get; set; }
        public string ConsumptionString { get; set; }
        public string PurchaseString { get; set; }
        public string BranchNo { get; set; }
        public string NewCustomerPurchase { get; set; }
        public int? NewCustomerServiceCount { get; set; }
        public int? NewCustomerCount { get; set; }
        public int? ReturnCustomerCount { get; set; }
        public int? RCServiceCount { get; set; }
        public int? BelongToCCategory { get; set; }
        public int? PurchaseCustomerCount { get; set; }
        public int? ConsumptionCustomerCount { get; set; }
        public int? PurchaseServiceCount { get; set; }
        public int? ConsumptionServiceCount { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
