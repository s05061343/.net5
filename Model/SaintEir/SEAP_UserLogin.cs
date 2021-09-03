using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SEAP_UserLogin
    {
        public int UserLoginNo { get; set; }
        public string UserId { get; set; }
        public string AuthToken { get; set; }
        public string DeviceToken { get; set; }
        public string DeviceName { get; set; }
        public int? IsLoginIn { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Password { get; set; }
        public string CertificateId { get; set; }
    }
}
