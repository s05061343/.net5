using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flDocDatum
    {
        public int Id { get; set; }
        public int DocTypeId { get; set; }
        public string Data { get; set; }
        public string ListTitle { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public int CreatorDepartmentId { get; set; }
        public string CreatorDepartmentName { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifierId { get; set; }
        public string ModifierName { get; set; }
        public int ModifierDepartmentId { get; set; }
        public string ModifierDepartmentName { get; set; }
        public string DocNo { get; set; }
        public int Flag { get; set; }
        public int VerifyLevel { get; set; }
        public int? VersionId { get; set; }
    }
}
