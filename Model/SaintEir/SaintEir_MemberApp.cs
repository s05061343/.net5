using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_MemberApp
    {
        public int MemberAppNo { get; set; }
        public int MemberNo { get; set; }
        public string Token { get; set; }
        public string DeviceToken { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int? IsLoginIn { get; set; }
        public string DeviceType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
