using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecordGroup
    {
        public int MedicalRecordGroupNo { get; set; }
        public int? BelongToForm { get; set; }
        public int? BelongToGroupBy { get; set; }
        public string GroupByName { get; set; }
        public int? Flag { get; set; }
        public string BackgroundImage { get; set; }
        public int BackgroundImageWidth { get; set; }
        public int BackgroundImageHeight { get; set; }
    }
}
