using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalFormTag
    {
        public int MedicalFormTagNo { get; set; }
        public string Tag { get; set; }
        public string Id { get; set; }
        public string PreviewClass { get; set; }
        public string SignedClass { get; set; }
        public string Title { get; set; }
    }
}
