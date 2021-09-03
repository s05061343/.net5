using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ClinicClassify
    {
        public int ClinicClassifyNo { get; set; }
        public string ClassifyType { get; set; }
        public string NameInChinese { get; set; }
        public string NameInEnglish { get; set; }
        public int? OrderBy { get; set; }
        public string ProductClassify { get; set; }
    }
}
