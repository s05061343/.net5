using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Supplier
    {
        public int SupplierNo { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierKeyman { get; set; }
        public string SupplierKeymanPhone { get; set; }
        public string Note { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Flag { get; set; }
        public string AccountNo { get; set; }
        public int? PayType { get; set; }
        public string ListOrder { get; set; }
        public int? CompanyType { get; set; }
        public string VATnumber { get; set; }
        public string SupplierNumber { get; set; }
        public string BelongToBranch { get; set; }
    }
}
