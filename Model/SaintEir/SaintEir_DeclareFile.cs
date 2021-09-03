using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_DeclareFile
    {
        public int DeclareFileNo { get; set; }
        public int? BelongToDeclare { get; set; }
        public string FileName { get; set; }
        public string UploadFileName { get; set; }
        public int? Flag { get; set; }
    }
}
