using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SEAP_Certificate
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public string CertificateFilePath { get; set; }
        public string APPFilePath { get; set; }
        public string APPVersion { get; set; }
        public string APPMiniVersion { get; set; }
    }
}
