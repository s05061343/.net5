using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_DocRecord
    {
        public string BelongToBranch { get; set; }
        public string BranchName { get; set; }
        public int? MemberNo { get; set; }
        public string AnamnesisNo { get; set; }
        public string FullName { get; set; }
        public string DocRecord { get; set; }
        public int? No { get; set; }
        public int? Form { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Date { get; set; }
        public string CreatedBy { get; set; }
        public string FullNameInChinese { get; set; }
        public int? Status { get; set; }
        public int? Flag { get; set; }
        public string Application { get; set; }
    }
}
