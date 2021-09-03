using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flDocType
    {
        public SaintEir_flDocType()
        {
            SaintEir_flDocNos = new HashSet<SaintEir_flDocNo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string TableName { get; set; }
        public string Prefix { get; set; }
        public int? FirstNodeId { get; set; }
        public int Is_Flow { get; set; }
        public int Is_Design { get; set; }
        public int? TitleFieldId { get; set; }
        public int Is_Deleted { get; set; }
        public string Memo { get; set; }
        public string Description { get; set; }
        public int Is_DepartmentManagerVerify { get; set; }
        public int Is_SetVerifyLevel { get; set; }
        public int? VersionId { get; set; }

        public virtual ICollection<SaintEir_flDocNo> SaintEir_flDocNos { get; set; }
    }
}
